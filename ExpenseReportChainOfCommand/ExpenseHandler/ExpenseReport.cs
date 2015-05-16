namespace ExpenseReportChainOfCommand.ExpenseHandler {
    public class ExpenseReport {
        public decimal Cost { get; set; }
        public ApprovalResponse Approved { get; set; }

        public ExpenseReport(decimal cost) {
            Cost = cost;
        }
    }
}