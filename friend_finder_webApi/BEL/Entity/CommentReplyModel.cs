using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity
{
    public class CommentReplyModel:CommentModel
    {
        public CommentReplyModel()
        {
            Replies = new List<ReplyModel>();
        }
        public virtual List<ReplyModel> Replies { get; set; }
    }
}
