using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTut.Data
{
    public class BlogpostService
    {
        private static List<BlogPost> posts = new()
        {
            new BlogPost
            {
                Title = "Efterårsferie",
                Date = new DateTime(2021, 6, 30),
                BodyText = "Hej alle Gräshult'ere Så er vi også på! Vi vil også rigtig gerne til Gräshult i efterårsferien fra 16-23/10. Vi tager gerne Kommandantboligen hvis det er den der er ledig... :-)<br />Vh Milene og Patrick"
            },
            new BlogPost
            {
                Title = "Juleferieønsker",
                Date = new DateTime(2021, 7, 9),
                BodyText = "Vi vil meget gerne booke kommandantboligen fra 23-26/12.. Knus fra JensOtto og Jonna"
            },
            new BlogPost
            {
                Title = "Juleferieønsker",
                Date = new DateTime(2021, 7, 9),
                BodyText = "Vi vil meget gerne booke kommandantboligen fra 23-26/12.. Knus fra JensOtto og Jonna"
            },
            new BlogPost
            {
                Title = "Juleferieønsker",
                Date = new DateTime(2021, 7, 9),
                BodyText = "Vi vil meget gerne booke kommandantboligen fra 23-26/12.. Knus fra JensOtto og Jonna"
            },
            new BlogPost
            {
                Title = "Juleferieønsker",
                Date = new DateTime(2021, 7, 9),
                BodyText = "Vi vil meget gerne booke kommandantboligen fra 23-26/12.. Knus fra JensOtto og Jonna"
            },
            new BlogPost
            {
                Title = "Ny menu under Regler - Dokumenter og Link",
                Date = new DateTime(2021, 6, 30),
                BodyText = "Jeg har indsat en ny menu med navnet 'Dokumenter og links' under REGLER. Heri har jeg placeret vigtigte dokumenter og links. Hvis I har nogle gode links eller dokumenter, som I ønsker at dele, så send det i en mail til mig på allanljohannesen@gmail.com."
            }
        };

        public Task<List<BlogPostCard>> GetBlogpostCardsAsync()
        {
            return Task.FromResult(posts.Select(p => new BlogPostCard(p)).ToList());
        }
    }
}