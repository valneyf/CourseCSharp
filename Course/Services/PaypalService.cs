using System.Globalization;
using System.Collections.Generic;

namespace Course.Services {
    class PaypalService : IOnlinePaymentService {
        public double Interest(double amount, int months) {
            double quota = amount + (amount*0.01)*months;

            return quota;
        }

        public double PaymentFee(double amount) {
            double fee = amount + amount * 0.02;

            return fee;
        }

    }
}
