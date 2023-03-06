using FirstMVCApp.DataContext;
using FirstMVCApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMVCApp.Repositories
{
    public class MembershipTypesRepository
    {
        private readonly ProgrammingClubDataContext _context;
        public MembershipTypesRepository(ProgrammingClubDataContext context)
        {
            _context = context;
        }
        public DbSet<MembershipTypeModel> GetMembershipTypes()
        {
            return _context.MembershipTypes;
        }
        public MembershipTypeModel GetMembershipTypeById(Guid id)
        {
            MembershipTypeModel membershipType = _context.MembershipTypes.FirstOrDefault(x => x.IdMembershipType == id);
            return membershipType;
        }

        public void AddMembershipType(MembershipTypeModel model) 
        {
            model.IdMembershipType = Guid.NewGuid();

            _context.MembershipTypes.Add(model);
            _context.SaveChanges();
        }

        public void UpdateMembershipType(MembershipTypeModel model)
        {
            _context.MembershipTypes.Update(model);
            _context.SaveChanges();
        }
    }
}
