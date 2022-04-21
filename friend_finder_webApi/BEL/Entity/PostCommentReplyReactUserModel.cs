using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL.Entity
{
    public class PostCommentReplyReactUserModel:PostModel
    {

        public PostCommentReplyReactUserModel()
        {
            Comments = new List<CommentReplyModel>();
            Reacts = new List<ReactModel>();
        }

        public virtual List<CommentReplyModel> Comments { get; set; }
        public virtual UserEmployeeModel User { get; set; }
        public virtual List<ReactModel> Reacts { get; set; }
    }
}
