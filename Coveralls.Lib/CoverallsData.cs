﻿using Newtonsoft.Json;

namespace Coveralls.Lib
{
    public sealed class CoverallsData
    {
        [JsonProperty("service_name")]
        public string ServiceName { get; set; }

        [JsonProperty("service_job_id", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ServiceJobId { get; set; }

        [JsonProperty("repo_token")]
        public string RepoToken { get; set; }

        [JsonProperty("source_files")]
        public CoverageFile[] SourceFiles { get; set; }

        [JsonProperty("git", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public GitData Git { get; set; }
    }
}