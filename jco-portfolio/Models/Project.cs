﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Portfolio.Models
{
    public class Project
    {
        public string full_name { get; set; }
        public string html_url { get; set; }

        public static async Task<List<Project>> GetStarredRepos()
        {
            var client = new RestClient("https://api.github.com");
            var request = new RestRequest("users/jamescosborn/starred", Method.GET);
            request.AddHeader("User-Agent", "jamescosborn");
            request.AddParameter("sort", "starred");
            request.AddParameter("direction", "asc");

            var response = await GetResponseContentAsync(client, request) as RestResponse;
            JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(response.Content);
            var repoList = JsonConvert.DeserializeObject(jsonResponse["full_name"].ToString());  
            List<Project> top3stars = repoList.ToList();
            return repoList;
        }

        public static Task<IRestResponse> GetResponseContentAsync(RestClient theClient, RestRequest theRequest)
        {
            var tcs = new TaskCompletionSource<IRestResponse>();
            theClient.ExecuteAsync(theRequest, response => {
                tcs.SetResult(response);
            });
            return tcs.Task;
        }
    }
}