using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySampleWebApi.Resources;

namespace MySampleWebApi.Controllers
{
    /// <summary>
    /// ユーザーの検索・変更用APIコントローラ。
    /// </summary>
    [Produces("application/json", Type = typeof(User))]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private static User[] users = new User[] {
            new User(){ id = 1, Name="User 1", Email = "user1@hoge.com", CreatedAt=DateTime.Now },
            new User(){ id = 2, Name="User 2", Email = "user2@hoge.com", CreatedAt=DateTime.Now },
            new User(){ id = 3, Name="User 3", Email = "user3@hoge.com", CreatedAt=DateTime.Now },
        };


        /// <summary>
        /// ユーザーの一覧を返す。
        /// </summary>
        /// <returns></returns>
        // GET api/users
        [HttpGet]
        public IEnumerable<User> Get() {
            return users;
        }

        /// <summary>
        /// 指定されたIdを持つユーザーを返す。
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/users/5
        [HttpGet("{id:long}")]
        public IActionResult Get(long id) {
            var user = users.FirstOrDefault(u => u.id == id);
            if (user == null) {
                return NotFound();
            }
            return Ok(user);
        }

        /// <summary>
        /// ユーザーを新規登録する。
        /// </summary>
        /// <param name="user"></param>
        // POST api/users
        [HttpPost]
        public void Post([FromBody]User user) {
        }

        /// <summary>
        /// ユーザーを更新する。
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        // PUT api/users/5
        [HttpPut("{id:long}")]
        public void Put(long id, [FromBody]User user) {
        }

        /// <summary>
        /// ユーザーを削除する。
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/users/5
        [HttpDelete("{id:long}")]
        public void Delete(long id) {
        }
    }
}