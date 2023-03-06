using FirstMVCApp.DataContext;
using FirstMVCApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMVCApp.Repositories
{
    public class MembersRepository
    {
        private readonly ProgrammingClubDataContext _context;
        public MembersRepository(ProgrammingClubDataContext context)
        {
            _context = context;
        }

        public DbSet<MemberModel> GetMember()
        {
            return _context.Members;
        }

        public MemberModel GetMemberById(Guid id)
        {
            MemberModel memberModel = _context.Members.FirstOrDefault(x => x.IdMember == id);
            return memberModel;
        }

        public void AddMember(MemberModel memberModel)
        {
            memberModel.IdMember = Guid.NewGuid();

            _context.Members.Add(memberModel);
            _context.SaveChanges();
        }

        public void UpdateMember(MemberModel memberModel)
        {
            _context.Members.Update(memberModel);
            _context.SaveChanges();
        }

        public void DeleteMemberById(Guid id)
        {
            var member = _context.Members.FirstOrDefault(a => a.IdMember == id);
            _context.Members.Remove(member);
            _context.SaveChanges();
        }
    }
}
