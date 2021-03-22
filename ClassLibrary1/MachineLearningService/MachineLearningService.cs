using System;
using System.Collections.Generic;
using System.Text;
using DataAccesLayer;
using DataAccesLayer.Entity;
using MyMLAppML.Model;
using System.Linq;

namespace MachineLearningLayer.MachineLearningService
{
    public class MachineLearningService : IMachineLearningService
    {
        private readonly MachineContext _context;

        public MachineLearningService(MachineContext context)
        {
            _context = context;
        }

        public bool CreateComment(Comment comment)
        {
            ModelInput input = new ModelInput()
            {
                SentimentText = comment.Text
            };

            var result = ConsumeModel.Predict(input);

            bool sentimentresult = result.Prediction == "1" ? true : false;

            comment.Toxic = sentimentresult;
            comment.PostedDate = DateTime.Now;

            _context.Comments.Add(comment);

            _context.SaveChanges();

            return sentimentresult;
        }

        public List<Comment> ListComments()
        {
            return _context.Comments.OrderBy(c => c.PostedDate).ToList();
        }

        public List<Comment> ListCommentsFilter(bool toxic)
        {
            return _context.Comments.Where(c => c.Toxic.Equals(toxic)).OrderBy(c => c.PostedDate).ToList();
        }
    }
}
