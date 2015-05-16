namespace ExpenseReportChainOfCommand.ExpenseHandler {
    public class VicePresident : IExpenseHandler {
        public ExpenseReport HandleExpense(ExpenseReport expenseReport)
        {
            if (expenseReport.Cost <= 5000) {
                expenseReport.Approved = true;
            }
        }

        public void RegisterNext(IExpenseHandler expenseHandler) {
            throw new System.NotImplementedException();
        }
    }
}