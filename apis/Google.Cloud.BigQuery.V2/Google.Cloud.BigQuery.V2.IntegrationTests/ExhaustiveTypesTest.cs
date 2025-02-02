// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Xunit;

namespace Google.Cloud.BigQuery.V2.IntegrationTests
{
    /// <summary>
    /// Check that we can handle every type, for all operations.
    /// </summary>
    [Collection(nameof(BigQueryFixture))]
    public class ExhaustiveTypesTest
    {
        private readonly BigQueryFixture _fixture;

        public ExhaustiveTypesTest(BigQueryFixture fixture)
        {
            _fixture = fixture;
        }

        // No explicit tests for InsertRow or CreateTable - they are implicitly tested
        // by us being able to create and populate the table in the fixture setup.

        [Fact]
        public void StandardQuery()
        {
            var table = GetTable();
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var rows = client.ExecuteQuery($"SELECT * FROM {table}", parameters: null).ToList();
            ValidateRows(rows);
        }

        [Fact]
        public void ListRows()
        {
            var rows = GetTable().ListRows().ToList();
            ValidateRows(rows);
        }

        private void ValidateRows(List<BigQueryRow> rows)
        {
            Assert.Equal(1, rows.Count);
            var row = rows[0];
            Assert.Equal("single string value", (string) row["single_string"]);
            Assert.Equal(true, (bool) row["single_bool"]);
            Assert.Equal(Encoding.UTF8.GetBytes("some bytes"), (byte[]) row["single_bytes"]);
            AssertDateTimeEqual(new DateTime(2017, 2, 14, 0, 0, 0, DateTimeKind.Unspecified), (DateTime) row["single_date"]);
            AssertDateTimeEqual(new DateTime(2017, 2, 14, 10, 11, 12, DateTimeKind.Unspecified), (DateTime) row["single_datetime"]);
            Assert.Equal(new TimeSpan(12, 15, 22) + TimeSpan.FromTicks(1234560), (TimeSpan) row["single_time"]);
            AssertDateTimeEqual(new DateTime(2017, 1, 20, 5, 6, 37, DateTimeKind.Utc) + TimeSpan.FromTicks(6543210), (DateTime) row["single_timestamp"]);
            Assert.Equal(123456789012L, (long) row["single_int64"]);
            Assert.Equal(1.25, (double) row["single_float64"]);
            Assert.Equal(BigQueryNumeric.Parse("1234567890123456789012345678.123456789"), (BigQueryNumeric) row["single_numeric"]);
            Assert.Equal(BigQueryBigNumeric.Parse("123456789012345678901234567890123456789.12345678901234567890123456789012345678"), (BigQueryBigNumeric) row["single_big_numeric"]);
            Assert.Equal(BigQueryGeography.Parse("POINT(1 2)"), (BigQueryGeography) row["single_geography"]);
            Assert.Equal("{\"x\":10,\"y\":\"text\"}", row["single_json"]);

            var singleRecord = (Dictionary<string, object>) row["single_record"];
            Assert.Equal("nested string", (string) singleRecord["single_string"]);
            Assert.Equal(new[] { "nested string 1", "nested string 2" }, (string[]) singleRecord["repeated_string"]);
            var nestedRecord = (Dictionary<string, object>) singleRecord["nested_record"];
            Assert.Equal(-10L, (long) nestedRecord["a"]);
            Assert.Equal(20L, (long) nestedRecord["b"]);

            Assert.Equal(new[] { "array string value 1", "array string value 2" }, (string[]) row["array_string"]);
            Assert.Equal(new[] { true, false }, (bool[]) row["array_bool"]);
            Assert.Equal(new[] { Encoding.UTF8.GetBytes("bytes1"), Encoding.UTF8.GetBytes("bytes2") }, (byte[][]) row["array_bytes"]);
            AssertDateTimesEqual(
                new[] { new DateTime(2017, 2, 15), new DateTime(2017, 2, 16) },
                (DateTime[]) row["array_date"]);
            AssertDateTimesEqual(
                new[] { new DateTime(2017, 2, 15, 10, 11, 12, DateTimeKind.Unspecified), new DateTime(2017, 2, 16, 10, 11, 12, DateTimeKind.Unspecified) },
                (DateTime[]) row["array_datetime"]);
            Assert.Equal(new[] { new TimeSpan(12, 15, 22), new TimeSpan(10, 53, 10) }, (TimeSpan[]) row["array_time"]);
            AssertDateTimesEqual(
                new[] { new DateTime(2017, 3, 20, 5, 6, 37, DateTimeKind.Utc), new DateTime(2017, 4, 20, 5, 6, 37, DateTimeKind.Utc) },
                (DateTime[]) row["array_timestamp"]);
            Assert.Equal(new [] { 1234567890123L, 12345678901234L }, (long[]) row["array_int64"]);
            Assert.Equal(new[] { -1.25, 2.5 }, (double[]) row["array_float64"]);
            Assert.Equal(new[] { BigQueryNumeric.Parse("1234567890123456789012345678.123456789"), BigQueryNumeric.Parse("123.456") },
                (BigQueryNumeric[]) row["array_numeric"]);
            Assert.Equal(new[] { BigQueryBigNumeric.Parse("123456789012345678901234567890123456789.12345678901234567890123456789012345678"), BigQueryBigNumeric.Parse("123.456") },
                (BigQueryBigNumeric[])row["array_big_numeric"]);
            Assert.Equal(new[] { BigQueryGeography.Parse("POINT(1 2)"), BigQueryGeography.Parse("POINT(1 3)") },
                (BigQueryGeography[]) row["array_geography"]);
            Assert.Equal(new[] { "{\"x\":10,\"y\":\"text1\"}", "{\"x\":20,\"y\":\"text2\"}" }, row["array_json"]);

            var arrayRecords = (Dictionary<string, object>[]) row["array_record"];

            Assert.Equal("array record string 1", (string) arrayRecords[0]["single_string"]);
            Assert.Equal(new[] { "array record string 1.1", "array record string 1.2" }, (string[]) arrayRecords[0]["repeated_string"]);
            nestedRecord = (Dictionary<string, object>) arrayRecords[0]["nested_record"];
            Assert.Equal(-100L, (long) nestedRecord["a"]);
            Assert.Equal(200L, (long) nestedRecord["b"]);

            Assert.Equal("array record string 2", (string) arrayRecords[1]["single_string"]);
            Assert.Equal(new[] { "array record string 2.1", "array record string 2.2" }, (string[]) arrayRecords[1]["repeated_string"]);
            nestedRecord = (Dictionary<string, object>) arrayRecords[1]["nested_record"];
            Assert.Equal(-1000L, (long) nestedRecord["a"]);
            Assert.Equal(2000L, (long) nestedRecord["b"]);
        }

        [Fact]
        public void QueryParameters()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.String, "foo"));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Bool, true));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Int64, 123456L));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Float64, 123.75));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Bytes, new byte[] { 1, 2, 3, 4 }));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Date, new DateTime(2017, 2, 14)));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.DateTime, new DateTime(2017, 2, 14, 17, 25, 30, DateTimeKind.Unspecified)));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Timestamp, new DateTime(2017, 2, 14, 17, 25, 30, DateTimeKind.Utc)));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Time, new TimeSpan(0, 1, 2, 3, 456)));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Numeric, BigQueryNumeric.Parse("1234567890123456789012345678.123456789")));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.BigNumeric, BigQueryBigNumeric.Parse("123456789012345678901234567890123456789.12345678901234567890123456789012345678")));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Geography, BigQueryGeography.Parse("POINT(1 2)")));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Json, "{\"x\":10,\"y\":\"text\"}"));

            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Array, new[] { "foo", "bar" }));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Array, new[] { true, false }));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Array, new[] { 123456L, -1234L }));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Array, new[] { 123.75, 10.5 }));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Array, new[] { new byte[] { 1, 2, 3, 4 }, new byte[] { 255, 254, 253, 252 } }));
            // Date/DateTime/Timestamp arrays need to be given the types explicitly.
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Array,
                new[] { new DateTime(2017, 2, 14), new DateTime(2017, 2, 15) })
                { ArrayElementType = BigQueryDbType.Date });
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Array,
                new[] { new DateTime(2017, 2, 14, 17, 25, 30, DateTimeKind.Unspecified), new DateTime(2017, 2, 15, 17, 25, 30, DateTimeKind.Unspecified) })
                { ArrayElementType = BigQueryDbType.DateTime });
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Array,
                new[] { new DateTime(2017, 2, 14, 17, 25, 30, DateTimeKind.Utc), new DateTime(2017, 2, 15, 17, 25, 30, DateTimeKind.Utc) })
                { ArrayElementType = BigQueryDbType.Timestamp });
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Array,
                new[] { new TimeSpan(0, 1, 2, 3, 456), new TimeSpan(0, 23, 59, 59, 987) }));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Array,
                new[] { BigQueryNumeric.Parse("1234567890123456789012345678.123456789"), BigQueryNumeric.Parse("123.456") }));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Array,
                new[] { BigQueryBigNumeric.Parse("123456789012345678901234567890123456789.12345678901234567890123456789012345678"), BigQueryBigNumeric.Parse("123.456") }));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Array,
                new[] { BigQueryGeography.Parse("POINT(1 2)"), BigQueryGeography.Parse("POINT(1 3)") }));
            AssertParameterRoundTrip(client, new BigQueryParameter(BigQueryDbType.Array,
               new[] { "{\"x\": 10, \"y\": \"text1\"}", "{\"x\": 20, \"y\": \"text2\"}" }));
        }

        // Parameterized test to make it easy to add more test cases.
        // See https://github.com/googleapis/google-cloud-dotnet/issues/4031 and
        // https://github.com/googleapis/google-cloud-dotnet/issues/4821 for background.
        [Theory]
        [InlineData("2004-07-26T15:25:28.173333Z")] // Value is "1.090855528173333E9"
        [InlineData("1899-12-31T23:00:00.000000Z")] // Vaue is "-2.2089924E9"
        public void TimestampRounding(string timestamp)
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            var parsedLocally = DateTime.ParseExact(timestamp, "yyyy-MM-dd'T'HH:mm:ss.FFFFFF'Z'",
                CultureInfo.InvariantCulture, DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);
            // Note: we're deliberately passing the parameter as a string so the conversion happens on the server.
            // This means we can't use AssertParameterRoundTrip.
            var parameter = new BigQueryParameter(BigQueryDbType.String, timestamp);
            var results = client.ExecuteQuery(
                "SELECT CAST(? AS TIMESTAMP) AS value",
                new[] { parameter },
                new QueryOptions { ParameterMode = BigQueryParameterMode.Positional }).ToList();
            Assert.Equal(1, results.Count);
            var returned = Assert.IsType<DateTime>(results[0]["value"]);
            AssertDateTimeEqual(parsedLocally, returned);
        }

        private void AssertParameterRoundTrip(BigQueryClient client, BigQueryParameter parameter)
        {
            var results = client.ExecuteQuery(
                "SELECT ? AS value",
                new[] { parameter },
                new QueryOptions { ParameterMode = BigQueryParameterMode.Positional }).ToList();
            Assert.Equal(1, results.Count);
            Assert.Equal(parameter.Value, results[0]["value"]);
            if (parameter.Value is DateTime)
            {
                AssertDateTimeEqual((DateTime) parameter.Value, (DateTime) results[0]["value"]);
            }
        }

        // Assertion for DateTime, including the Kind.
        private void AssertDateTimeEqual(DateTime expected, DateTime actual)
        {
            Assert.Equal(expected, actual);
            Assert.Equal(expected.Kind, actual.Kind);
        }

        private void AssertDateTimesEqual(DateTime[] expected, DateTime[] actual)
        {
            foreach (var pair in expected.Zip(actual, (e, a) => new { e, a }))
            {
                AssertDateTimeEqual(pair.e, pair.a);
            }
        }

        private BigQueryTable GetTable()
        {
            var client = BigQueryClient.Create(_fixture.ProjectId);
            return client.GetTable(_fixture.DatasetId, _fixture.ExhaustiveTypesTableId);
        }

        // Here rather than in the fixture (where it's used) for ease of writing/checking the tests above.
        internal static BigQueryInsertRow GetSampleRow() => new BigQueryInsertRow
        {
            ["single_string"] = "single string value",
            ["single_bool"] = true,
            ["single_bytes"] = Encoding.UTF8.GetBytes("some bytes"),
            ["single_date"] = new DateTime(2017, 2, 14).AsBigQueryDate(),
            ["single_datetime"] = new DateTime(2017, 2, 14, 10, 11, 12, DateTimeKind.Unspecified),
            ["single_time"] = new TimeSpan(12, 15, 22) + TimeSpan.FromTicks(1234560), // 10 ticks per microsecond
            ["single_timestamp"] = new DateTime(2017, 1, 20, 5, 6, 37, DateTimeKind.Utc) + TimeSpan.FromTicks(6543210),
            ["single_int64"] = 123456789012L, // Larger than an int32
            ["single_float64"] = 1.25,
            ["single_numeric"] = BigQueryNumeric.Parse("1234567890123456789012345678.123456789"),
            ["single_big_numeric"] = BigQueryBigNumeric.Parse("123456789012345678901234567890123456789.12345678901234567890123456789012345678"),
            ["single_geography"] = BigQueryGeography.Parse("POINT(1 2)"),
            ["single_json"] = "{\"x\":10,\"y\":\"text\"}",
            ["single_record"] = new BigQueryInsertRow
            {
                ["single_string"] = "nested string",
                ["repeated_string"] = new[] { "nested string 1", "nested string 2" },
                ["nested_record"] = new BigQueryInsertRow { ["a"] = -10, ["b"] = 20 }
            },

            ["array_string"] = new[] { "array string value 1", "array string value 2" },
            ["array_bool"] = new[] { true, false },
            ["array_bytes"] = new[] { Encoding.UTF8.GetBytes("bytes1"), Encoding.UTF8.GetBytes("bytes2") },
            ["array_date"] = new[] { new DateTime(2017, 2, 15).AsBigQueryDate(), new DateTime(2017, 2, 16).AsBigQueryDate() },
            ["array_datetime"] = new[] { new DateTime(2017, 2, 15, 10, 11, 12, DateTimeKind.Unspecified), new DateTime(2017, 2, 16, 10, 11, 12, DateTimeKind.Unspecified) },
            ["array_time"] = new[] { new TimeSpan(12, 15, 22), new TimeSpan(10, 53, 10) },
            ["array_timestamp"] = new[] { new DateTime(2017, 3, 20, 5, 6, 37, DateTimeKind.Utc), new DateTime(2017, 4, 20, 5, 6, 37, DateTimeKind.Utc) },
            ["array_int64"] = new[] { 1234567890123L, 12345678901234L },
            ["array_float64"] = new[] { -1.25, 2.5 },
            ["array_numeric"] = new[] { BigQueryNumeric.Parse("1234567890123456789012345678.123456789"), BigQueryNumeric.Parse("123.456") },
            ["array_big_numeric"] = new[] { BigQueryBigNumeric.Parse("123456789012345678901234567890123456789.12345678901234567890123456789012345678"), BigQueryBigNumeric.Parse("123.456") },
            ["array_geography"] = new[] { BigQueryGeography.Parse("POINT(1 2)"), BigQueryGeography.Parse("POINT(1 3)") },
            ["array_json"] = new[] { "{\"x\":10,\"y\":\"text1\"}", "{\"x\":20,\"y\":\"text2\"}" },
            ["array_record"] = new[] {
                    new BigQueryInsertRow
                    {
                        ["single_string"] = "array record string 1",
                        ["repeated_string"] = new[] { "array record string 1.1", "array record string 1.2" },
                        ["nested_record"] = new BigQueryInsertRow { ["a"] = -100, ["b"] = 200 }
                    },
                    new BigQueryInsertRow
                    {
                        ["single_string"] = "array record string 2",
                        ["repeated_string"] = new[] { "array record string 2.1", "array record string 2.2" },
                        ["nested_record"] = new BigQueryInsertRow { ["a"] = -1000, ["b"] = 2000 }
                    },
                }
        };
    }
}
