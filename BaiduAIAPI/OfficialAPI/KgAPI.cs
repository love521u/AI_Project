﻿using System.Collections.Generic;
using Baidu.Aip.Kg;
using BaiduAIAPI;
namespace Baidu.Aip.API
{
    internal class KgAPI
    {
        private readonly Pie _pieClient;

        public KgAPI()
        {
            _pieClient = new Pie(Config.clientId,Config.clientSecret);
        }


        public void TaskCreate()
        {
            var options = new Dictionary<string, object>
            {
                {"limit_count", 1}
            };
            _pieClient.TaskCreate("name", "template_content", "input_mapping_file", "url_pattern", "output_file",
                options);
        }

        public void TaskUpdate()
        {
            var options = new Dictionary<string, object>
            {
                {"name", "newName"},
                {"template_content", "new templte content"}
            };
            _pieClient.UpdateTask(1, options);
        }

        public void TaskInfo()
        {
            var ret = _pieClient.GetTaskInfo(1);
        }

        public void GetTaskList()
        {
            var options = new Dictionary<string, object>
            {
                {"id", 123}
            };
            var ret = _pieClient.GetTasks(options);
        }

        public void StartTask()
        {
            var ret = _pieClient.StartTask(1);
        }

        public void GetTaskStatus()
        {
            var ret = _pieClient.GetTaskStatus(1);
        }
    }
}