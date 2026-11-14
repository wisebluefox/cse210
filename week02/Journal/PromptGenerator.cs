using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public PromptGenerator()
    {
        // CHILDHOOD
        _prompts.Add("Childhood~|~What is your earliest childhood memory, and what makes it stand out?");
        _prompts.Add("Childhood~|~What was your favorite thing to do when you were little?");
        _prompts.Add("Childhood~|~Who was the person you looked up to most as a child, and why?");
        _prompts.Add("Childhood~|~What was your favorite place to go when you were growing up?");
        _prompts.Add("Childhood~|~What is something you believed as a child that makes you laugh now?");
        _prompts.Add("Childhood~|~What was your biggest childhood dream?");
        _prompts.Add("Childhood~|~What childhood experience made you feel especially happy or safe?");
        _prompts.Add("Childhood~|~What was something you were afraid of as a child?");
        _prompts.Add("Childhood~|~If you could relive one day from your childhood, which day would you choose?");
        _prompts.Add("Childhood~|~What is one thing about your childhood that you wish you could experience again?");

        // TEENAGE YEARS
        _prompts.Add("Teenage Years~|~How would you describe yourself as a teenager in three words?");
        _prompts.Add("Teenage Years~|~What music, movie, or book defined your teenage years?");
        _prompts.Add("Teenage Years~|~Who was your closest friend during your teenage years, and what made your friendship special?");
        _prompts.Add("Teenage Years~|~What was the most rebellious thing you did as a teenager?");
        _prompts.Add("Teenage Years~|~What was something you desperately wanted during your teenage years?");
        _prompts.Add("Teenage Years~|~What was your biggest insecurity back then?");
        _prompts.Add("Teenage Years~|~What experience taught you an important lesson as a teenager?");
        _prompts.Add("Teenage Years~|~What did you imagine your adult life would look like?");
        _prompts.Add("Teenage Years~|~If you could give your teenage self one piece of advice, what would it be?");
        _prompts.Add("Teenage Years~|~What is something your teenage self would be surprised to discover about your life today?");

        // ADULTHOOD
        _prompts.Add("Adulthood~|~What moment made you realize you were officially an adult?");
        _prompts.Add("Adulthood~|~What is the biggest decision you have ever made for yourself?");
        _prompts.Add("Adulthood~|~What accomplishment are you most proud of?");
        _prompts.Add("Adulthood~|~What has been the most challenging period of your adult life, and what helped you through it?");
        _prompts.Add("Adulthood~|~What is something you understand about life now that you didn't understand when you were younger?");
        _prompts.Add("Adulthood~|~What does a successful life look like to you?");
        _prompts.Add("Adulthood~|~What is one mistake that taught you something valuable?");
        _prompts.Add("Adulthood~|~When have you felt the most independent?");
        _prompts.Add("Adulthood~|~What is something you wish you had started doing earlier in life?");
        _prompts.Add("Adulthood~|~What kind of person are you still working toward becoming?");

        // ROMANCE
        _prompts.Add("Romance~|~What does being in love mean to you?");
        _prompts.Add("Romance~|~What was your first experience of having a crush, and what do you remember about it?");
        _prompts.Add("Romance~|~What qualities make someone attractive to you beyond their physical appearance?");
        _prompts.Add("Romance~|~What is the most romantic thing someone could do for you?");
        _prompts.Add("Romance~|~Do you believe in love at first sight, or do you think love develops over time? Why?");
        _prompts.Add("Romance~|~What is your idea of a perfect date?");
        _prompts.Add("Romance~|~What have your past romantic experiences taught you about yourself?");
        _prompts.Add("Romance~|~What does a healthy, lasting relationship look like to you?");
        _prompts.Add("Romance~|~What little everyday gestures make you feel loved and appreciated?");
        _prompts.Add("Romance~|~If you could write a letter to your future spouse or partner, what would you want them to know about you?");

        // LIKES AND DISLIKES
        _prompts.Add("Likes and Dislikes~|~What are five things that can instantly make your day better?");
        _prompts.Add("Likes and Dislikes~|~What is your favorite smell, and what memories does it bring back?");
        _prompts.Add("Likes and Dislikes~|~What food could you eat every week without getting tired of it?");
        _prompts.Add("Likes and Dislikes~|~What kind of environment makes you feel most at peace?");
        _prompts.Add("Likes and Dislikes~|~What is a song you could listen to a hundred times without getting bored?");
        _prompts.Add("Likes and Dislikes~|~What is something you love that other people might find unusual?");
        _prompts.Add("Likes and Dislikes~|~What type of people do you naturally gravitate toward?");
        _prompts.Add("Likes and Dislikes~|~What is your favorite way to spend a completely free day?");
        _prompts.Add("Likes and Dislikes~|~What is something you dislike that most people seem to enjoy?");
        _prompts.Add("Likes and Dislikes~|~If you could surround yourself with only the things that make you happy, what would your life look like?");

        // DREAMS AND ADVENTURES
        _prompts.Add("Dreams and Adventures~|~If money were no obstacle, what would you do with the next five years of your life?");
        _prompts.Add("Dreams and Adventures~|~What country or place have you always dreamed of visiting, and what would you do there?");
        _prompts.Add("Dreams and Adventures~|~What is one skill you have always wanted to learn but haven't attempted yet?");
        _prompts.Add("Dreams and Adventures~|~If you could start a business or create something of your own, what would it be?");
        _prompts.Add("Dreams and Adventures~|~What is one adventure you want to experience at least once in your lifetime?");
        _prompts.Add("Dreams and Adventures~|~Where would you choose to live if you could make a home anywhere in the world?");
        _prompts.Add("Dreams and Adventures~|~What is something you want to accomplish that would make your younger self proud?");
        _prompts.Add("Dreams and Adventures~|~What is one fear you would like to overcome?");
        _prompts.Add("Dreams and Adventures~|~What kind of legacy would you like to leave behind?");
        _prompts.Add("Dreams and Adventures~|~Imagine yourself ten years from now, living a life you absolutely love. What does an ordinary day in that life look like?");

        // HOLIDAYS AND TRADITIONS
        _prompts.Add("Holidays and Traditions~|~What is your favorite holiday, and what makes it special to you?");
        _prompts.Add("Holidays and Traditions~|~What is your most memorable holiday celebration from childhood?");
        _prompts.Add("Holidays and Traditions~|~What family traditions did you grow up with, and which ones would you like to continue?");
        _prompts.Add("Holidays and Traditions~|~What is the best holiday gift you have ever received, and why was it meaningful?");
        _prompts.Add("Holidays and Traditions~|~What holiday tradition would you love to introduce into your own future family?");
        _prompts.Add("Holidays and Traditions~|~Have you ever spent a holiday somewhere completely different from what you were used to? What was the experience like?");
        _prompts.Add("Holidays and Traditions~|~What does your ideal Christmas, Thanksgiving, or other favorite holiday look like?");
        _prompts.Add("Holidays and Traditions~|~Is there a holiday that brings back bittersweet memories for you? What makes it meaningful?");
        _prompts.Add("Holidays and Traditions~|~If you could spend one holiday again with someone from your past, who would it be and what would you do together?");
        _prompts.Add("Holidays and Traditions~|~If you could create an entirely new holiday, what would it celebrate, and how would people celebrate it?");

        // BOOKS, MOVIES AND MUSIC
        _prompts.Add("Books, Movies and Music~|~What was your favorite book as a child, and what did you love about it?");
        _prompts.Add("Books, Movies and Music~|~What movie or television show defined your teenage years?");
        _prompts.Add("Books, Movies and Music~|~What song instantly takes you back to a particular time in your life?");
        _prompts.Add("Books, Movies and Music~|~What fictional character did you relate to most when you were younger, and why?");
        _prompts.Add("Books, Movies and Music~|~What book, movie, or show changed the way you think about something?");
        _prompts.Add("Books, Movies and Music~|~What kind of music did you listen to during your happiest or most difficult period of life?");
        _prompts.Add("Books, Movies and Music~|~Is there a story, movie, or book you wish you could experience for the first time all over again?");
        _prompts.Add("Books, Movies and Music~|~What fictional world would you love to visit, and what would you do if you lived there?");
        _prompts.Add("Books, Movies and Music~|~How have your tastes in books, movies, music, or television changed as you have gotten older?");
        _prompts.Add("Books, Movies and Music~|~If someone wanted to understand your life story through only five books, movies, or songs, which five would you choose?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}
