﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserTask
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(500)]
        public string TaskDescription { get; set; }
        public bool Active { get; set; }
        [ForeignKey("User")]
        public string UserID { get; set; }
        public User User { get; set; }
        [ForeignKey("TaskState")]
        public int TaskStateID { get; set; }
        public TaskState TaskState { get; set; }
        [ForeignKey("EventPriority")]
        public int PID { get; set; }
        public EventPriority EventPriority { get; set; }

        
    }
    public class TaskState
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
    }
}
