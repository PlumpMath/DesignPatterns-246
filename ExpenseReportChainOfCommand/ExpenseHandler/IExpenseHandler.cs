namespace ExpenseReportChainOfCommand.ExpenseHandler {
    public interface IExpenseHandler {
        ApprovalResponse HandleExpense(ExpenseReport expenseReport);
        void RegisterNext(IExpenseHandler expenseHandler);
    }
}