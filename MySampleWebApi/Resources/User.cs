using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySampleWebApi.Resources
{
    public class User
    {
        /// <summary>
        /// ユーザーのIdentity
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// ユーザー名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ユーザーのメールアドレス
        /// 各種通知メッセージがこのアドレスに送られる。
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 登録日時
        /// </summary>
        public DateTime CreatedAt { get; set; }

    }
}
