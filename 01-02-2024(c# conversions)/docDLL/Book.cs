using System;

namespace Docdll
{

    /// <summary>
    /// Represents a simple Book class.
    /// </summary>
    public class Book
    {
        /// <summary>
        /// Gets or sets the title of the book.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the author of the book.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Gets or sets the publication year of the book.
        /// </summary>
        public int PublicationYear { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Book"/> class.
        /// </summary>
        /// <param name="title">The title of the book.</param>
        /// <param name="author">The author of the book.</param>
        /// <param name="publicationYear">The publication year of the book.</param>
        public Book(string title, string author, int publicationYear)
        {
            Title = title;
            Author = author;
            PublicationYear = publicationYear;
        }

        /// <summary>
        /// Displays information about the book.
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, Year: {PublicationYear}");
        }

        /// <summary>
        /// Calculates the years since publication.
        /// </summary>
        /// <returns>The number of years since publication.</returns>
        public int YearsSincePublication()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - PublicationYear;
        }
    }

}