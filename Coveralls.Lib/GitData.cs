﻿using Newtonsoft.Json;

namespace Coveralls.Lib
{
    public sealed class GitData
    {
        [JsonProperty("head", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public CommitData Head { get; set; }

        [JsonProperty("branch", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Branch { get; set; }

        [JsonProperty("remotes", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GitRemotes Remotes { get; set; }
    }

    public sealed class CommitData
    {
        [JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("author_name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Author { get; set; }

        [JsonProperty("author_email", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AuthorEmail { get; set; }

        [JsonProperty("message", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Message { get; set; }
    }

    public sealed class GitRemotes
    {
        [JsonProperty("name", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("url", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; set; }
    }
}