using GreaterGradesBackend.Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GreaterGradesBackend.Services.Interfaces
{
    public interface IClassService
    {
        Task<IEnumerable<ClassDto>> GetAllClassesAsync();
        
        Task<ClassDto> GetClassByIdAsync(int classId);
        
        Task<ClassDto> CreateClassAsync(CreateClassDto createClassDto);
        Task<bool> RemoveStudentFromClassAsync(int classId, int userId);
        Task<bool> AddStudentToClassAsync(int classId, int userId);

        Task<bool> RemoveTeacherFromClassAsync(int classId, int userId);
        Task<bool> AddTeacherToClassAsync(int classId, int userId);
        
        Task<bool> UpdateClassAsync(int classId, UpdateClassDto updateClassDto);
        
        Task<bool> DeleteClassAsync(int classId);
    }
}
