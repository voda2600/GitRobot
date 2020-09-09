using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Student
    {
        public int StudentId { get; set; }
        public int GroupId { get; set; }
        public string GroupNum { get; set; }
        public string Name { get; set; }
        public List<int> Marks { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"StudentId={StudentId} GoupId={GroupId} GroupNum={GroupNum} Name={Name} Кол-во оценок={Marks.Count}";
        }

    }
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupNum { get; set; }
        private List<Student> Students { get; set; }
            = new List<Student>();
        public Student this[int id]
        {
            get
            {
                var st = Students.FirstOrDefault(
                            s => s.StudentId == id);
                if (st is null)
                    throw new ArgumentOutOfRangeException($"" +
                        $"Студента с id-{id} нет в этой группе");
                return st;
            }
            set
            {
                var st = Students.FirstOrDefault(
                            s => s.StudentId == value.StudentId);
                value.StudentId = id;
                value.GroupId = this.GroupId;
                value.GroupNum = this.GroupNum;
                if (st != null)
                    Students[Students.IndexOf(st)] = value;
                else
                    Students.Add(value);
            }
        }
        public Student this[string name]
        {
            get
            {
                var st = Students.FirstOrDefault(
                            s => s.Name == name);
                if (st is null)
                    throw new ArgumentOutOfRangeException($"" +
                        $"Студента с именем-{name} нет в группе");
                return st;
            }
            set
            {
                var st = Students.FirstOrDefault(
                           s => s.Name == value.Name);
                value.GroupId = this.GroupId;
                value.GroupNum = this.GroupNum;
                if (st != null)
                    Students[Students.IndexOf(st)] = value;
                else
                    Students.Add(value);
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Группа - {GroupNum}:");

            Students.ForEach(s => sb.AppendLine(s.ToString()));

            return sb.ToString();
        }
    }
}