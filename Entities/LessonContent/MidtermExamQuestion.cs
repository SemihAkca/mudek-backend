﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.LessonContent
{
    public class MidtermExamQuestion:IEntity
    {
        public int Id { get; set; }
        public int MidtermExamId { get; set; }
        public string QuestionName { get; set; }
        public string? ImagePath { get; set; }
        public string? QuestionContent { get; set; }
        public DateTime Date { get; set; }
    }
}
    