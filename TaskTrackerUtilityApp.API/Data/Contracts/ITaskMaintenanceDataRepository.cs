﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskTrackerUtilityApp.API.Models;

namespace TaskTrackerUtilityApp.API.Data
{
    public interface ITaskMaintenanceDataRepository
    {
        IEnumerable<TaskMaintenance> GetAllTaskMaintenance();
        TaskMaintenance GetTaskByID(int taskID);
        void AddTaskMaintenance(TaskMaintenance taskMaintenance);
        void UpdateTaskMaintenance(TaskMaintenance taskMaintenance, TaskMaintenance newTaskMaintenance);
        void DeleteTaskMaintenance(TaskMaintenance taskMaintenance);
        IEnumerable<TaskMaintenance> GetTasksByStatusID(string statusID);
        IEnumerable<TaskMaintenance> GetTasksByUserID(int userID);

    }

}