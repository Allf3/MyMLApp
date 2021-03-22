using System;
using System.Collections.Generic;
using System.Text;
using DataAccesLayer.Entity;

namespace MachineLearningLayer.MachineLearningService
{
    public interface IMachineLearningService
    {
        bool CreateComment(Comment comment);
        List<Comment> ListCommentsFilter(bool toxic);
        List<Comment> ListComments();
    }
}
