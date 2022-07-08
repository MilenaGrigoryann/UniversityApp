using System;
using UniversityAppp.Models;

public interface ITeacherService
{
    IEnumerable<Teacher>? GetAll();
    Teacher? Get(Guid id);
    void Create(Teacher? teacher);
    void Update(Teacher? teacher);
    void Delete(Guid id);
}
