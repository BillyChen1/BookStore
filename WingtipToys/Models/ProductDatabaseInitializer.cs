using System.Collections.Generic;
using System.Data.Entity;

namespace WingtipToys.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }

        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "编程语言"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "算法与数据结构"
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "数据库"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "计算机网络"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "设计模式"
                },
            };

            return categories;
        }

        private static List<Product> GetProducts()
        {
            var products = new List<Product> {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Java核心技术",
                    Description = "一看到「机械工业出版社」，我就知道事情并不简单。是的，这本讲的很全面，书中的代码示例都很好，很适合Java通用学习。",
                    ImagePath="Javacore.png",
                    UnitPrice = 50.88,
                    CategoryID = 1
               },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Effective Java",
                    Description = "这本算是进阶书籍了，里面讲的全是Java使用的经验技巧和指导意见，等Java比较熟之后再看看一定会非常有收获的",
                    ImagePath="effectiveJava.png",
                    UnitPrice = 35.55,
                     CategoryID = 1
               },
                new Product
                {
                    ProductID = 3,
                    ProductName = "深入理解 Java 虚拟机",
                    Description = "我Fo了，还是「机工社的」！都知道JVM虚拟机对于Java而言极其重要，这本是理解JVM机制比较好的书了",
                    ImagePath="JVM.png",
                    UnitPrice = 65.99,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Java并发编程实战",
                    Description = "这本书的原文作者们本来就是Java并发工具专家组的主要成员，所以权威性杠杠滴，但如果学Java并发上来就钻这本书，而这本书又是翻译过来的，确实是有点晦涩了",
                    ImagePath="JavaThread.png",
                    UnitPrice = 45.65,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Java编程思想",
                    Description = "好家伙，又是「机械工业出版社」，还是黑皮书，Java的“圣经”。如果是纯新手还是上面的《Java核心技术》稍微好接受一些，当然待我们有些基础之后，这本书也可以啃一啃，从圣经里多吸收一些思想总是好的。",
                    ImagePath="thinking-in-java.png",
                    UnitPrice = 95.00,
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "数据结构与算法分析",
                    Description = "这本书它本来它就是国外数据结构与算法分析的经典教材，系统全面且严谨，适合对Java语言比较熟，而且数据结构和算法有些了解的同学，当然既然是黑皮书，压力肯定是有的，肝了它吧。",
                    ImagePath="DataStructure.png",
                    UnitPrice = 34.95,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "算法",
                    Description = "这是另外一本Java语言描述的经典数据结构和算法书。",
                    ImagePath="algorithm.png",
                    UnitPrice = 95.00,
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "MySQL必知必会",
                    Description = "书不厚，主讲SQL用法，入门不错，也可以当小册子查阅。",
                    ImagePath="mysql.png",
                    UnitPrice = 35.20,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "高性能MySQL",
                    Description = "上面的用法熟了，学习原理、提升数据库性能，可以读这本，不过书很厚，是一个长期攻坚战没跑了。",
                    ImagePath="mysql1.png",
                    UnitPrice = 40.88,
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "TCP/IP详解 卷1:协议",
                    Description = "计网的东西乍看起来好像很杂，但抓住分层的思想梳理总结之后其实也还好。就像这本书，表面看起来有点晦涩，但沉下心来完全能看懂。",
                    ImagePath="tcp-ip-protocol.png",
                    UnitPrice = 32.95,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "计算机网络：自顶向下方法",
                    Description = "说上面那本晦涩的，那就看这本吧",
                    ImagePath="network.png",
                    UnitPrice = 95.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "图解TCP/IP",
                    Description = "生动有趣，图解TCP/IP",
                    ImagePath="tcp-ip.png",
                    UnitPrice = 26.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "图解HTTP",
                    Description = "图解HTTP",
                    ImagePath="http.png",
                    UnitPrice = 29.00,
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Head First设计模式",
                    Description = "设计模式入门款，文字轻松、配图丰富、逻辑清晰，通过它步入设计模式之门没问题。",
                    ImagePath="headfirst.png",
                    UnitPrice = 95.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "大话设计模式",
                    Description = "设计模式入门款，文字轻松、配图丰富、逻辑清晰，通过它步入设计模式之门没问题。",
                    ImagePath="designPattern.png",
                    UnitPrice = 35.00,
                    CategoryID = 5
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "设计模式：可复用面向对象软件的基础",
                    Description = "有了一定的编码经验，进阶深入再学习和理解看这本比较好，这是理论提高。",
                    ImagePath="designPattern1.png",
                    UnitPrice = 42.95,
                    CategoryID = 5
                }             
            };

            return products;
        }
    }
}