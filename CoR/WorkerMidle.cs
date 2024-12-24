﻿namespace CoR;

public class WorkerMidle : IWorker
{
    private IWorker _nextWorker;
    public void SetNext(IWorker worker)
    {
        _nextWorker = worker;
    }

    public string HandleTask(string task, int level)
    {
        if (level <= 5)
        {
            return $"{this.GetType().Name} выполнил задачу: {task}";
        }
        else if (_nextWorker != null)
        {
            return $"{this.GetType().Name} передал задачу следующему. " +
                   _nextWorker.HandleTask(task, level);
        }
        else
        {
            return $"Запрос {task} осталась невыполненной";
        }
    }
}