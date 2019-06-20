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
        public async Task<DownstreamResponse> Aggregate(List<DownstreamContext> responses)
        {
            // TODO: this is ugly af but good enough right now, will move to a composite service some day soon(TM)
            
            string one = await responses[0].DownstreamResponse.Content.ReadAsStringAsync();
            string two = await responses[1].DownstreamResponse.Content.ReadAsStringAsync();

            dynamic tutorialSummaries = JsonConvert.DeserializeObject(one);
            dynamic skills = JsonConvert.DeserializeObject(two);
            
            foreach (dynamic ts in tutorialSummaries)
            {
                List<dynamic> applicableSkills = new List<dynamic>();

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

            var result = JsonConvert.SerializeObject(tutorialSummaries);

            var headers = responses.SelectMany(x => x.DownstreamResponse.Headers).ToList();
            return new DownstreamResponse(new StringContent(result), HttpStatusCode.OK, headers, "");
        }
    }
}