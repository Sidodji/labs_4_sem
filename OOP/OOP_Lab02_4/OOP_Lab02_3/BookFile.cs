using System;
using System.Collections;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;


namespace OOP_Lab02_3
{
    public enum FileFormat
    {
        FB2 = 1,
        EPUB,
        TXT
    }

    [DataContract]
    public class BookFile : IComparable
    {
        // ПОЛЯ
        [DataMember]
        private string name;
        [DataMember]
        private string author;
        [DataMember]
        private int    year;
        [DataMember]
        private int    bookSize;
        [DataMember]
        private string publisher;
        [DataMember]
        private FileFormat fileFormat;
        [DataMember]
        private float  fileSize;
        [DataMember]
        private DateTime uploadDate;
        [DataMember]
        private string udk;
        
        // КОНСТРУКТОРЫ --------------------------------------------------------------------------

        public BookFile(string name, string author, int year, int bookSize, string publisher, FileFormat fileFormat, float fileSize, string udk, DateTime uploadDate)
        {
            this.Name = name;
            this.Author = author;
            this.Year = year;
            this.BookSize = bookSize;
            this.Publisher = publisher;
            this.FileFormat = fileFormat;
            this.FileSize = fileSize;
            this.UploadDate = uploadDate;
            this.UDK = udk;
        }

        // СВОЙСТВА --------------------------------------------------------------------------
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string Name 
        { 
            get { return name; }
            set { name =  value; }
        }
           
             
      
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string Author 
        {  get { return author; }
           set { author = value; }
        }
            
        
        [Required]
        [Range(2000, 2021)]
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
           
        [Required]
        
        public int BookSize 
        { 
            get { return bookSize; }
            set { bookSize = value; }

        }
            
        [Required]
        
        public string Publisher
        { 
            get { return publisher; }
            set { publisher = value; }
        }
            
        [Required]
        [Range(50,300)]
        public float FileSize 
        {  
            get { return fileSize; }
            set { fileSize = value; }
        }
           

        public DateTime UploadDate {
            get => uploadDate;
            set => uploadDate = value;
        }
        internal FileFormat FileFormat {
            get => fileFormat;
            set => fileFormat = value;
        }

        [Required]
        [UDKValidation]
        public string UDK
        {
            get => udk;
            set => udk = value;
        }

        // МЕТОДЫ --------------------------------------------------------------------------

        public int CompareTo(object obj)
        {
            return name.CompareTo(obj);
        }
    }
}
