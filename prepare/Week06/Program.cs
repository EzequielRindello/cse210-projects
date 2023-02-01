using System;
class Program
{
    static void Main(string[] args)
    {
        var rand = new Random();
        string[] movies = { "deadpool", "batmanvssuperman", "findingdory", "titanic", "suicidesquad", "lordoftherings", "harrypotter", "jurassicpark", "hungergames", "despicableme" };
        List<string> randomMovies = movies.ToList();

        for (int i = 0; i < movies.Length / 2; i++)
        {
            var randNum = rand.Next(i, randomMovies.Count);
            var temp = randomMovies[randNum];
            randomMovies[randNum] = randomMovies[i];
            randomMovies[i] = temp;
        }

        var randomMovie = randomMovies.First(); 
        randomMovies.Remove(randomMovie);

        for (int i = 0; i < randomMovies.Count; i++)
        {
            Console.WriteLine(randomMovies[i]);
        }

    }

}