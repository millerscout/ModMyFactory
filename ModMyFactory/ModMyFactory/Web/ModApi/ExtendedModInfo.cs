﻿using ModMyFactory.Helpers;
using Newtonsoft.Json;

namespace ModMyFactory.Web.ModApi
{
    [JsonObject(MemberSerialization.OptIn)]
    sealed class ExtendedModInfo
    {
        [JsonProperty("releases")]
        public ModRelease[] Releases { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("github_path")]
        public string GitHubUrl { get; set; }

        [JsonProperty("license")]
        public LicenseInfo License { get; set; }

        [JsonProperty("changelog")]
        public string Changelog { get; set; }

        [JsonProperty("faq")]
        public string Faq { get; set; }

        public ModRelease LatestRelease => Releases.MaxBy(release => release.Version, new VersionComparer());
    }
}
