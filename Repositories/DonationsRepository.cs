using FirstMVCApp.DataContext;
using FirstMVCApp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstMVCApp.Repositories
{
    public class DonationsRepository
    {
        private readonly ProgrammingClubDataContext _context;
        public DonationsRepository(ProgrammingClubDataContext context)
        {
            _context = context;
        }
        public DbSet<DonationModel> GetDonation()
        {
            return _context.Donations;
        }
        public DonationModel GetDonationById(Guid id) 
        {
            DonationModel donation = _context.Donations.FirstOrDefault(x => x.IdDonation == id);
            return donation;
        }
        public void AddDonation(DonationModel donation)
        {
            donation.IdDonation = Guid.NewGuid();
            _context.Donations.Add(donation);
            _context.SaveChanges();
        }
        public void UpdateDonation(DonationModel donation)
        {
            _context.Donations.Update(donation);
            _context.SaveChanges();
        }
        public void DeleteDonation(Guid id) 
        {
            DonationModel donation = GetDonationById(id);
            _context.Donations.Remove(donation);
            _context.SaveChanges();
        }
    }
}
