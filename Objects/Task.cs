using System;
using System.Collections.Generic;

namespace ToDoList
{
    public class Task
    {
      private string Description {  get; set; }
      private int Id { get; set; }
      private static List<Task> Instances = new List<Task> {};


    public Task(string description)
    {
      Description = description;
      Instances.Add(this); // Adds task to the Instance list
      Id = Instances.Count; // assigns number to Id
    }

    public string GetDescription()
    {
      return Description;
    }

    public int GetId()
    {
      return Id;
    }

    public static List<Task> GetAll()
    {
      return Instances;
    }

    public static void ClearAll()
    {
      Instances.Clear();
    }

    public static Task Find(int searchId)
    {
      return Instances[searchId - 1];
    }
  }
}
