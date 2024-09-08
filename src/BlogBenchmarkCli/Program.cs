using BenchmarkDotNet.Running;
using BlogBenchmarks;

var summary = BenchmarkRunner.Run<ListInitializationBenchmarks>();