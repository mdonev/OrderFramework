//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Web;

//namespace OpenOrderFramework.Models
//{
//    public class Accessorie
//    {
//        [Key]
//        [ScaffoldColumn(false)]
//        public int accID { get; set; }
//        public Ketchup ketchup { get; set; }
//        public enum Ketchup
//        {
//            Low,
//            Medium,
//            High
//        }
//        public Mayonnaise mayonnaise { get; set; }
//        public enum Mayonnaise
//        {
//            Low,
//            Medium,
//            High
//        }

//        public Fries fries { get; set; }
//        public enum Fries
//        {
//            Little,
//            Big
//        }
//        public virtual Item Items { get; set; }
//    }
//}