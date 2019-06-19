using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Ocelot.Middleware;
using Ocelot.Middleware.Multiplexer;

namespace Ludio.Services.Gateway.Aggregators
{
    public class TutorialSummarySkillsAggregator : IDefinedAggregator
    {
        //public async Task<DownstreamResponse> Aggregate(List<DownstreamResponse> responses)
        //{

            //one = await responses[0].Content.ReadAsStringAsync();
            //dynamic two = await responses[1].Content.ReadAsStringAsync();

            //one.Skills = "";

            //var merge = $"{one}, {two}";
            //merge = merge.Replace("Hello", "Bye").Replace("{", "").Replace("}", "");
            
            //var headers = responses.SelectMany(x => x.Headers).ToList();
            //return new DownstreamResponse(new StringContent(merge), HttpStatusCode.OK, headers, "");
        //}

        public async Task<DownstreamResponse> Aggregate(List<DownstreamContext> responses)
        {
            string one = await responses[0].DownstreamResponse.Content.ReadAsStringAsync();
            string two = await responses[1].DownstreamResponse.Content.ReadAsStringAsync();

            dynamic tutorialSummaries = JsonConvert.DeserializeObject(one);

           

            dynamic skills = JsonConvert.DeserializeObject(two);

            
            List<dynamic> applicableSkills = new List<dynamic>();
            
            foreach (dynamic ts in tutorialSummaries)
            { 
                foreach (int id in ts.skillIds)
                {
                    foreach (dynamic s in skills)
                    {
                        

                        if (s.id == id)
                        {
                            applicableSkills.Add(s);
                        }
                    }
                }

                ts.skills = JArray.FromObject(applicableSkills);
            }

            return JsonConvert.SerializeObject(tutorialSummaries);
        }

    }
}