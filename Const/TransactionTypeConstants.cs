using System.ComponentModel;

namespace deposit_app.Const
{
	public static class TransactionTypeConstants
	{
		public const string AddType = "ea0272c7-92d0-49a6-893f-19a9edddf4e9";
		public const string TakeType = "6b440dd9-ff83-41b9-ad3f-fd69d8d8e0c5";
		public const string ProcentType = "8d42ee9b-56be-49b9-a441-a27f7d34bc46";

		public static string GetTransactionTypeNameById(Guid transactionTypeId)
		{
			if (transactionTypeId == Guid.Parse(AddType))
			{
				return "Пополнение";
			}

			if (transactionTypeId == Guid.Parse(TakeType))
			{
				return "Снятие";
			}

			if (transactionTypeId == Guid.Parse(ProcentType))
			{
				return "Зачисление процентов";
			}

			return "Данный тип транзакции не зарегистрирован в системе";
		}
	}
}
