
namespace BaseballPipeline.Shared.Services
{
    public interface IQuote
    {
        string Statement { get; set; }
        string Author { get; set; }
    }
    public class Quote : IQuote
    {
        public string? Statement { get; set; }
        public string? Author { get; set; }
    }

    public class QuoteService
    {
        private IEnumerable<Quote> Quotes { get; set; }

        public QuoteService()
        {
            Quotes = new Quote[]
            {
                new Quote(){ Author = "Yogi Berra", Statement = "\"Baseball is ninety percent mental. The other half is physical.\"" },
                new Quote(){ Author = "Yogi Berra", Statement = "\"Love is the most important thing in the world, but baseball is pretty good, too.\"" },
                new Quote(){ Author = "Yogi Berra", Statement = "\"Little League baseball is a very good thing because it keeps the parents off the streets.\"" },
                new Quote(){ Author = "Yogi Berra", Statement = "\"It's fun; baseball is fun.\"" },
                new Quote(){ Author = "Yogi Berra", Statement = "\"Slump? I'm not in a slump. I'm just not hitting.\"" },
                new Quote(){ Author = "Red Smith", Statement = "\"Ninety feet between the bases is the nearest thing to perfection that man has yet achieved.\""  },
                new Quote(){ Author = "Herb Caen", Statement = "\"The clock doesn't matter in baseball.\"" },
                new Quote(){ Author = "Roger Angell", Statement = "\"Any baseball is beautiful. No other small package comes as close to the ideal in design and utility.\"" },
                new Quote(){ Author = "Philip Roth", Statement = "\"Boys would be big leaguers. As everybody knows, but so would big leaguers be boys.\"" },
                new Quote(){ Author = "Roy Campanella", Statement = "\"You gotta be a man to play baseball for a living, but you gotta have a lot of little boy in you.\"" },
                new Quote(){ Author = "Willie Mays", Statement = "\"For all its gentility, its almost leisurely pace, baseball is violence under wraps.\"" },
                new Quote(){ Author = "Ty Cobb", Statement = "\"The great american game should be an unrelenting war of nerves.\"" },
                new Quote(){ Author = "Bob Feller", Statement = "\"Every day is a new opportunity. You can build on yesterday's success or put its failures behind\"" },
                new Quote(){ Author = "Pete Rose", Statement = "\"I'd walk through hell in a gasoline suit to keep playing baseball.\"" },
                new Quote(){ Author = "Stanley Coveleski", Statement = "\"It's tomorrow that counts. So you worry all the time. It never ends. Lord, baseball is a worrying thing.\"" },
                new Quote(){ Author = "Ted Williams", Statement = "\"Baseball is the only field of endeavor where a man can succeed three times out of ten and be considered a good performer.\"" },
                new Quote(){ Author = "Vance Law", Statement = "\"When you're in a slump, it's almost as if you look out at the field and it's one big glove.\"" },
                new Quote(){ Author = "Sandy Koufax", Statement = "\"The game has a cleanness. If you do a good job, the numbers say so.\"" },
                new Quote(){ Author = "Leo Durocher", Statement = "\"You don't save a pitcher for tomorrow. Tomorrow it may rain.\"" },
                new Quote(){ Author = "Bob Lemon", Statement = "\"The two most important things in life are good friends and a strong bullpen.\"" },
                new Quote(){ Author = "Jackie Robinson", Statement = "\"Baseball is like a poker game. Nobody wants to quit when he's losing; nobody wants to quit when you're ahead.\"" },
                new Quote(){ Author = "Rod Kanehl", Statement = "\"Baseball is a lot like life. the line drives are caught, the squibbers go for base hits. It's an unfair game.\"" },
                new Quote(){ Author = "Ernie Banks", Statement = "\"The only way to prove you're a good sport is to lose.\"" },
                new Quote(){ Author = "Joe Dimaggio", Statement = "\"You start chasing a ball and your brain immediatly commands your body\"" },
                new Quote(){ Author = "Lefty Gomez", Statement = "\"I'm throwing twice as hard as I ever did. It's just not getting there as fast.\"" },
                new Quote(){ Author = "Roberto Clemente", Statement = "\"I would be lost without baseball.\"" },
                new Quote(){ Author = "Al Spalding", Statement = "\"Baseball is a man maker.\"" },
                new Quote(){ Author = "Pat Gillick", Statement = "\"Baseball is about talent, hard work, and strategy. But at the deepest level, it’s about love, integrity, and respect.\"" },
                new Quote(){ Author = "Leo Durocher", Statement = "\"There are only five things you can do in baseball – run, throw, catch, hit and hit with power.\"" },
                new Quote(){ Author = "Casey Stengel", Statement = "\"There are three things you can do in a baseball game. You can win, or you can lose, or it can rain..\"" },
                new Quote(){ Author = "Bill Klem", Statement = "\"Baseball is more than a game to me, it’s a religion..\"" },
                new Quote(){ Author = "Branch Rickey", Statement = "\"Baseball is a game of inches.\"" },
                new Quote(){ Author = "Gabe Paul", Statement = "\"The great thing about baseball is there’s a crisis every day.\"" },
                new Quote(){ Author = "Juliana Hatfield", Statement = "\"Baseball is more than a game. It’s like life played out on a field.\"" },
                new Quote(){ Author = "Curt Schilling", Statement = "\"Baseball is not a sport you can achieve individually.\"" },
                new Quote(){ Author = "Mickey Mantle", Statement = "\"It was all I lived for, to play baseball.\"" },
                new Quote(){ Author = "Earl Weaver", Statement = "\"The key to winning baseball games is pitching, fundamentals, and three run homers.\"" },
                new Quote(){ Author = "Chuck Tanner", Statement = "\"What you have to remember is that baseball isn’t a week or a month but a season.\"" },
                new Quote(){ Author = "Lou Gehrig", Statement = "\"There is no room in baseball for discrimination. It is our national pastime and a game for all.\"" },
                new Quote(){ Author = "Carl Yastrzemski", Statement = "\"I think about baseball when I wake up in the morning. I think about it all day and I dream about it at night.\"" },
                new Quote(){ Author = "Ryne Sandberg", Statement = "\"In baseball, there’s always the next day.\"" },
                new Quote(){ Author = "Miguel Cabrera", Statement = "\"How can I feel pressure doing what I love to do?\"" },
                new Quote(){ Author = "Willie Stargell", Statement = "\"Baseball has always been a reflection of life. Like life, it adjusts. It survives everything.\"" },
                new Quote(){ Author = "Alvin Dark", Statement = "\"In this game of baseball, you live by the sword and die by it. You hit and get hit.\"" },
                new Quote(){ Author = "Sammy Sosa", Statement = "\"If you have a bad day in baseball, and start thinking about it, you will have 10 more.\"" },
                new Quote(){ Author = "Rogers Hornsby", Statement = "\"People ask me what I do in winter when there’s no baseball. I’ll tell you what I do. I stare out the window and wait for spring.\"" },
                new Quote(){ Author = "Lou Brock", Statement = "\"You can’t be afraid to make errors!\"" },
                new Quote(){ Author = "Chad Harbach", Statement = "\"Baseball is a team game but, at the same time, it’s a very lonely game...in baseball everyone has their little plot of the field to tend.\"" },
                new Quote(){ Author = "Cal Ripken, Jr.", Statement = "\"You could be a kid for as long as you want when you play baseball.\"" },
                new Quote(){ Author = "Tom Seaver", Statement = "\"In baseball, my theory is to strive for consistency, not to worry about the numbers.\"" },
                new Quote(){ Author = "Frank Robinson", Statement = "\"Close don’t count in baseball. Close only counts in horseshoes and grenades.\"" }
            };
        }

        public string GetRandomQuoteHtml()
        {
            Random rnd = new Random();
            int r = rnd.Next(Quotes.Count());
            var quote = Quotes.ElementAt(r);
            return $"<table><tr><td><em>{quote.Statement}</em></td></tr><tr><td style='text-align:right;padding-right:10px'>-&nbsp;{quote.Author}</td></tr></table>";
        }
    }
            
}