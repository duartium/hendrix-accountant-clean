using HendrixAccountant.ApplicationCore.DTOs;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface IExpenseRepository
    {
        bool Create(ExpenseDto expense);
    }
}
