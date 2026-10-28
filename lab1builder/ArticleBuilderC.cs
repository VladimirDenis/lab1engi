using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Security.Cryptography;


namespace lab1builder
{
    internal class ArticleBuilderC
    {
        public class Article
        {
            public string Title { get; set; }
            public string Authors { get; set; }
            public string Body { get; set; }
            public string Hash { get; set; }
        };
        public class ArticleBuilder {
            private Article article = new Article();
            public ArticleBuilder SetTitle(string title) {
                article.Title = title;
                return this;
            }

            public ArticleBuilder SetAuthors(string authors) {
                article.Authors = authors;
                return this;
            }

            public ArticleBuilder SetBody(string body) {
                article.Body = body;
                return this;
            }
            public ArticleBuilder SetHash(string hash) { 
                article.Hash = hash; 
                return this; 
            }
            public Article Build() { 
                return article;
            }
        }
        public Article ReadFile(string filepath)
        {
            using (StreamReader sr = new StreamReader(filepath)) {
                string title,author,body,hash,line,nextline;
                title = sr.ReadLine();
                author = sr.ReadLine();
                if (title == null || author == null) 
                    return null;
                body = sr.ReadLine();
                line = sr.ReadLine();

                while ((nextline = sr.ReadLine()) != null) {
                    body = string.Join("\r\n",body,line);
                    line = nextline;
                }
                hash = line;
                if (VerifyHash(body, hash))
                    return new ArticleBuilder()
                        .SetTitle(title)
                        .SetAuthors(author)
                        .SetBody(body)
                        .SetHash(hash)
                        .Build();
                else
                    return null; 
            }

        }
        public void WriteFile(string filepath,string filename, Article article) {
            string jsonPath, jsonString;
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(System.Text.Unicode.UnicodeRanges.All)
            };
            jsonString = JsonSerializer.Serialize(article, options);
            jsonPath = Path.Combine(
                Path.GetDirectoryName(filepath),
                filename + ".json"
            );
            File.WriteAllText(jsonPath, jsonString, Encoding.UTF8);
        }

        public string CalculateHash(string body){
            byte[] bytes, hashbytes;
            using (SHA256 sha = SHA256.Create())
            {
                bytes = Encoding.UTF8.GetBytes(body);
                hashbytes = sha.ComputeHash(bytes);

                return BitConverter.ToString(hashbytes).Replace("-", "");
            }
        }

        public bool VerifyHash(string body, string savedHash) {
            string calculateHash;
        if (string.IsNullOrEmpty(savedHash)) 
                return false;
        
        calculateHash = CalculateHash(body);
            return string.Equals(
                calculateHash,
                savedHash.Trim(),
                StringComparison.OrdinalIgnoreCase
                );
        }
    }
}
