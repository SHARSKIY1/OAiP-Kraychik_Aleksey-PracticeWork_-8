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

    public class AnotherSample
    {
        public int AInd { get; set; }
        public int AId { get; set; }
        public string AType { get; set; }
        public string AGetDate { get; set; }
        public string AStatus { get; set; }
        public string AResult { get; set; }

        public override string ToString()
        {
            return $"ID: {AId}, {AType}, Дата: {AGetDate}, Статус: {AStatus}, Результат: {AResult}";
        }
    }

    public class AnotLabList : List<AnotherSample> 
    {
        public void Add(int index, int Id, string Type, string GetDate, string Status, string Result) //другой класс для листа
        {
            this.Add(new AnotherSample { AInd = index, AId = Id, AType = Type, AGetDate = GetDate, AStatus = Status, AResult = Result });
        }
    }

    public class LabList : List<Sample> 
    { 
        public void Add(int Id, string Type, string GetDate, string Status, string Result) //1
        {
            this.Add(new Sample { Id = Id, Type = Type, GetDate = GetDate, Status = Status, Result = Result });
        }

        public void IndAdd(int index, int Id, string Type, string GetDate, string Status, string Result) //2
        {
            this.Insert(index, new Sample { Id = Id, Type = Type, GetDate = GetDate,Status = Status, Result = Result });
        }

        public void RemoveLast() //3
        {
            this.RemoveAt(this.Count - 1);
        }

        public void IndDelete(int index) //4
        {
            this.RemoveAt(index);
        }

        public int ElemCounts() //5
        {
            return this.Count;
        }

        public void IndChange(int index, int Id, string Type, string GetDate, string Status, string Result) //6
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

        public void ShowAll() //7
        {
            foreach (var item in this)
            {
                Console.WriteLine(item);
            }
        }

        public void IndShow(int index) //8
        {
            Console.WriteLine(this[index]);
        }

        public void ListInList(AnotLabList anotherlist) //9
        {
            foreach (var item in anotherlist)
            {
                Sample newSample = new Sample
                {
                    Id = item.AId,
                    Type = item.AType,
                    GetDate = item.AGetDate,
                    Status = item.AStatus,
                    Result = item.AResult
                };
                this.Add(newSample);
            }
        }

        public void ListInListByInd(int index, AnotLabList anotherlist) //10
        {
            int curindex = index;
            foreach (var item in anotherlist)
            {
                Sample newSample = new Sample
                {
                    Id = item.AId,
                    Type = item.AType,
                    GetDate = item.AGetDate,
                    Status = item.AStatus,
                    Result = item.AResult
                };
                this.Insert(curindex, newSample);
                curindex++;
            }
        }

        public void IndDelToInd(int firindex, int secindex) //11
        {
            for (; secindex >= firindex; secindex--)
            {
                this.RemoveAt(secindex);
            }
        }

        public void Clear()
        {
            this.Clear();
        }

        public void FindWithExer(int targetId)
        {
            bool found = false;
            foreach (var item in this)
            {
                if(item.Id > targetId)
                {
                    Console.WriteLine(item);
                    found = true;
                    break;
                }
            }
        }

        public void SortById()
        {
            this.Sort((x, y) => x.Id.CompareTo(y.Id));
            Console.WriteLine("Список отсортирован по ID");
        }

        public void Reverse()
        {
            this.Reverse();
        }

        public void Distinct()
        {
            this.Distinct();
        }
    }
}
