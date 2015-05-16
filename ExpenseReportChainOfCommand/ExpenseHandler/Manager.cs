namespace ExpenseReportChainOfCommand.ExpenseHandler {
    public class Manager : IExpenseHandler {
        private IExpenseHandler Next { get; set; }
        public ApprovalResponse HandleExpense(ExpenseReport expenseReport) {
            if (expenseReport.Cost <= 1000) {               
                return ApprovalResponse.Approved;
            }
            return Next.HandleExpense(expenseReport);
        }

        public void RegisterNext(IExpenseHandler expenseHandler) {
            Next = expenseHandler;
        }
    }
}