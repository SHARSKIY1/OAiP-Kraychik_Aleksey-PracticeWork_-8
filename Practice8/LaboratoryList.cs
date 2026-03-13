using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice8
{
    public class Sample
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string GetDate { get; set; }
        public string Status { get; set; }
        public string Result { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, {Type}, Дата: {GetDate}, Статус: {Status}, Результат: {Result}";
        }
    }

    public class LabList : List<Sample> 
    { 
        public void Add(int Id, string Type, string GetDate, string Status, string Result)
        {
            this.Add(new Sample { Id = Id, Type = Type, GetDate = GetDate, Status = Status, Result = Result });
        }

        public void IndAdd(int index, int Id, string Type, string GetDate, string Status, string Result)
        {
            this.Insert(index, new Sample { Id = Id, Type = Type, GetDate = GetDate,Status = Status, Result = Result });
        }

        public void RemoveLast()
        {
            this.RemoveAt(this.Count - 1);
        }

        public void IndDelete(int index)
        {
            this.RemoveAt(index);
        }

        public int ElemCounts()
        {
            return this.Count;
        }

        public void IndChange(int index, int Id, string Type, string GetDate, string Status, string Result)
        {
            if (index >= 0 && index < this.Count)
            {
                this[index].Id = Id;
                this[index].Type = Type;
                this[index].GetDate = GetDate;
                this[index].Status = Status;
                this[index].Result = Result;
                Console.WriteLine("Изменение элемента!");
            }
            else
            {
                Console.WriteLine("Нет такого индекса");
            }
        }

        public void ShowAll()
        {
            foreach (var item in this)
            {
                Console.WriteLine(item);
            }
        }

        public void IndShow(int index)
        {
            Console.WriteLine(this[index]);
        }
    }
}
