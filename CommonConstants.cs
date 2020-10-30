
// https://rm.mfc.ru/issues/41613 27.07.2020 imironov Ограничение использования типа колёсных пар 4.
// https://rm.mfc.ru/issues/40270 29.07.2020 imironov Скрывать извещения росжелдора, по бумажным записям, из журнала ТУ.
// https://rm.mfc.ru/issues/43381 08.09.2020 imironov Сервис для регистрации заявок на передачу в аренду (Транспрог).

using System;
using System.Collections.Generic;

namespace NVX.RZD.DataModel.Common
{
	/// <summary>
	/// Класс, который содержит переменные, используемые в системе.
	/// </summary>
	public class CommonConstants
	{
        /// <summary>
        /// форматер для преобразования дат в строку без времени
        /// </summary>
        public const string DateWithoutTimeFormat = "dd.MM.yyyy";
		/// <summary>
		/// ИД железнодорожной администрации Российской железной дороги.
		/// </summary>
		public static readonly int RAILWAY_ADMINISTRATION_ID = 20;

		/// <summary>
		/// ИД причины регистрации вагона. 1.
		/// </summary>
		public static readonly int REGISTER_REQUEST_REASON_ID = 1;


		/// <summary>
		/// ИД причины регистрации из инвентарного парка. 2.
		/// </summary>
		public static readonly int NOT_REGISTER_REQUEST_REASON_ID = 2;

		/// <summary>
		/// ИД причины регистрации из инвентарного парка с изменением типа. 3.
		/// </summary>
		public static readonly int REGISTER_WITH_CHANGE_TYPE_REQUEST_REASON_ID = 3;

        /// <summary>
		/// ИД причины Плановый пономерной учет. 4.
        /// </summary>
        public static readonly int REREGISTRATION_REQUEST_REASON_ID = 4;

		/// <summary>
		/// ИД причины изменения собственника. 5.
		/// </summary>
		public static readonly int CHANGE_OWNER_REQUEST_REASON_ID = 5;

		/// <summary>
		/// ИД причины изменения собственника. 5.. Модификация снятие с аренды
		/// </summary>
		public static readonly int CHANGE_OWNER_REQUEST_REASON_ID_WITH_RETURN_VAGON_TO_OWNER = 51;

		/// <summary>
		/// ИД причины передачи в аренду. 7.
		/// </summary>
		public static readonly int RENT_REQUEST_REASON_ID = 7;

		/// <summary>
		/// ИД причины передачи в аренду. 7. Модификация продление аренды
		/// </summary>
		public static readonly int RENT_REQUEST_REASON_ID_WITH_RENTED_VAGONS = 71;

		/// <summary>
		/// ИД причины возврата вагона арендатору. 8.
		/// </summary>
		public static readonly int RETURN_VAGON_TO_OWNER_REQUEST_REASON_ID = 8;

		/// <summary>
		/// ИД причины изменения дороги или станции. 9.
		/// </summary>
		public static readonly int CHANGE_ROAD_OR_STATION_REQUEST_REASON_ID = 9;
		
		/// <summary>
		/// ИД причины продления срока службы. 10.
		/// </summary>
		public static readonly int LIFE_SPAN_PROLONGED = 10;

		/// <summary>
		/// ИД причины исключения. 11.
		/// </summary>
		public static readonly int REMOVE_REQUEST_REASON_ID = 11;

        /// <summary>
        /// ИД причины исключения. 11.1.
        /// </summary>
        public static readonly int REMOVE_REQUEST_REASON_ID_WITH_CHANGE_OWNER = 111;

		/// <summary>
		/// ИД причины Передача собственных грузовых вагонов в парк инвентарых вагонов. 13.
		/// </summary>
		public static readonly int CHANGE_OWNER_TO_RZHD_REQUEST_REASON_ID = 13;

        /// <summary>
        /// ИД причины Реорганизация собственника. 16.
        /// </summary>
        public static readonly int REORGANIZE_OWNER_REQUEST_REASON_ID = 16;

		//RZDUCHET-6649
		//УИП-5
		//УИП-итс-7
		/// <summary>
		/// Префикс УИПа заявки
		/// </summary>
		public static readonly string REQUEST_UID_PREFIX = "УИП-итс-7/";

		//RZDUCHET-6649
		//-ис
		//ис
		/// <summary>
		/// Постфикс УИПа заявки
		/// </summary>
		public static readonly string REQUEST_UID_POSTFIX = "ис";

		public static readonly string VersionReplaceMarkerConst = "VersionForReplace";

		public static readonly string StringDateFormat = "dd.MM.yyyy";

		public static readonly int MaxOperationCountPerRequest = 100;

		/// <summary>
		/// Максимально возможная дата 2999-12-31 00:00:00.000.
		/// </summary>
		public static readonly DateTime RecordLastDate = DateTime.Parse("2999-12-31 00:00:00.000");

		/// <summary>
		/// Максимальный размер файла для загрузки в систему.
		/// </summary>
		public static readonly int MaxFileAttachSize = 104857600;

		// https://rm.mfc.ru/issues/43381 08.09.2020 imironov Сервис для регистрации заявок на передачу в аренду (Транспрог).
		/// <summary>
		/// Максимальный размер файла-заявки для загрузки в систему.
		/// </summary>
		public static readonly int MaxRequestFileSize = 8388608;

		// https://rm.mfc.ru/issues/43381 08.09.2020 imironov Сервис для регистрации заявок на передачу в аренду (Транспрог).
		/// <summary>
		/// Максимальный размер файла прикладываемого к заявке.
		/// </summary>
		public static readonly int MaxRequestAttachFileSize = 52428800;

		/// <summary>
		/// Код собственника ОАО "РЖД".
		/// </summary>
		public static readonly string RzhdOwnerCode = "000000";

		/// <summary>
		/// Код отказа по операции.
		/// </summary>
		public static readonly string IvcjaRejectCode = "99";

		/// <summary>
		/// Код отказа по операции.
		/// </summary>
		public static readonly string WithdrawRequestStatusAvailable = "WithdrawRequestStatusAvailable";

		/// <summary>
		/// Сообщение об ошибке со смешанной арендой.
		/// </summary>
		public static readonly string ErrorMessageAboutMixedRent = "\nВнимание! Отмена операции!\nВагоны с номерами ({0}) не были добавлены в заявку.\nЗапрещено создавать заявки со смешанной арендой";

		/// <summary>
		/// Сообщение об ошибке о добавлении вагонов с арендой в заявку по седьмой причине.
		/// </summary>
		public static readonly string ErrorMessageAboutRentedVagonsInSeventhReason = "\nВнимание! Вагоны с номерами ({0}) не были добавлены в заявку.\nЭти вагоны находятся в аренде.\nОперация по смене арендатора над вагонами, находящимися в аренде, запрещена.\n";

		/// <summary>
		/// Сервисное сообщение с предложением сделать заявку с модификацией седьмой причины.
		/// </summary>
		public static readonly string ServiceMessageAboutModificationSeventhReason = "Хотите создать заявку на продление аренды?\r\nВыбранные вагоны с номерами {0} находятся в аренде.";

        /// <summary>
        /// Сервисное сообщение с предложением сделать заявку с модификацией 11 причины.
        /// </summary>
        public static readonly string ServiceMessageAboutModificationEleventhReason = "Хотите создать заявку по комплексной причине 5-11?\r\n";

		/// <summary>
		/// Сервисное сообщение с предложением сделать заявку с модификаией пятой причины.
		/// </summary>
        public static readonly string ServiceMessageAboutModificationFifthReason = "Если вы хотите создать заявку по комплексной причине 8-5(возврат собственнику, смена собственника), нажмите кнопку \"8-5\".\r\nЕсли вы хотите создать заявку по комплексной причине 8-5-7(возврат собственнику, смена собственника, передача в аренду), нажмите кнопку \"8-5-7\"\r\nВыбранные вагоны с номерами {0} находятся в аренде.";

		/// <summary>
		/// Сообщение об ошибке о добавлении вагонов с арендой в заявку по пятой причине.
		/// </summary>
		public static readonly string ErrorMessageAboutRentedVagonsInFifthReason = "\nВнимание! Вагоны с номерами ({0}) не были добавлены в заявку.\nЭти вагоны находятся в аренде.\nОперация по смене собственника над вагонами, находящимися в аренде, запрещена.\n";

        /// <summary>
        /// Сообщение об ошибке о добавлении вагонов с арендой в заявку по 16 причине.
        /// </summary>
        public static readonly string ErrorMessageAboutRentedVagonsInSixteenReason = "\nВнимание! Вагоны с номерами ({0}) не были добавлены в заявку.\nЭти вагоны находятся в аренде.\nОперация по реорганизации собственника над вагонами, находящимися в аренде, запрещена.\n";

		/// <summary>
		/// Список кодов порталов
		/// </summary>
        public static readonly List<string> PortalCodes = new List<string>() { "trp", "nmr", "vgn", "rzd" };

        /// <summary>
        /// Regex-шаблон "только цифры"
        /// </summary>
	    public static readonly string OnlyNumbersRegexPattern = @"^\d+$";

		/// <summary>
		/// Значение migrate в базе данных
		/// </summary>
		public static readonly string MigrateValue = "migrate";
        //TODO не забываем изменять во вьюхе Арма-руководителя
        /// <summary>
        /// Положительные финальные статусы
        /// </summary>
        public static readonly int[] AcceptedFinalStatuses = { 4, 5 };
        //TODO не забываем изменять во вьюхе Арма-руководителя
        /// <summary>
        /// Финальные статусы частично принятых заявок
        /// </summary>
        public static readonly int[] PartialAcceptedFinalStatuses = { 6 };
        //TODO не забываем изменять во вьюхе Арма-руководителя
        /// <summary>
        /// Финальные статусы для Росжелдора об отказе
        /// </summary>
        public static readonly int[] DeclinedFinalStatusesForRzd = { 8, 11 };

        /// <summary>
        /// Финальные статусы для Росжелдора об отказе
        /// </summary>
        public static readonly int[] DeclinedFinalStatusesForTU = { 8, 11, 10, 17 }; 
        
        /// <summary>
        /// Финальные статусы для агентов
        /// </summary>
        public static readonly int[] DeclinedFinalStatusesForAgent = { 8, 11, 17 };

        public static readonly int[] RegisterReasons = { 1, 2, 3 };

		/// <summary>
		/// Для установки имени и должности руководителя Росжелдор, используется Ид ТУ -1.
		/// </summary>
		public const int RoszheldorTuId = -1;

		public const int RoszheldorManagementId = 1;

		/// <summary>
		/// Заголовок сообщения об истечении срока регистрации вагона.
		/// </summary>
		public static readonly string InfoVagonTitle = "Информация по вагонам";


		/// <summary>
		/// Сообщение об истечении срока регистрации вагона.
		/// </summary>
		public static readonly string InfoVagonMessage = "Есть вагоны у которых истекает срок перерегистрации({0}). Их список можно посмотреть на вкладке Вагоны.";


		/// <summary>
		/// ИД основания 7. Продление срока службы железнодорожного подвижного состава, в том числе в случае его модернизации.
		/// </summary>
		public static readonly int BASE_LIFE_SPAN_PROLONGED_ID = 7;

		/// <summary>
		/// ИД основания 5. Передача в аренду.
		/// </summary>
		public static readonly int BASE_RENT_ID = 5;
		
		/// <summary>
		/// ИД основания 3. Плановый пономерной учет железнодорожного подвижного состава.
		/// </summary>
		public static readonly int BASE_REGISTRATION_ID = 3;

		/// <summary>
		/// Заголовок сообщения об истечении срока регистрации вагона.
		/// </summary>
		public static readonly string LinkErrorTitle = "Ошибка перехода к заявке";


		/// <summary>
		/// Сообщение об истечении срока регистрации вагона.
		/// </summary>
		public static readonly string LinkErrorMessage = "Заявка, указанная по ссылке, не найдена в системе или не может быть открыта пользователю.";

		/// <summary>
		/// Дата запрета использования типа колесных пар с кодом 4 "РВ2-Ш-957-Г" в операциях.
		/// </summary>
		// https://rm.mfc.ru/issues/41613 27.07.2020 imironov
		public static readonly DateTime WheelPairType4BannedDate = DateTime.Parse("2020-07-29 00:00:00.000");

		/// <summary>
		/// Код типа колесных пар "РВ2-Ш-957-Г".
		/// </summary>
		// https://rm.mfc.ru/issues/41613 27.07.2020 imironov
		public static readonly int WheelPairTypeBanned = 4;

		/// <summary>
		/// Дата, после которой надо скрывать извещения росжелдора, по бумажным записям, из журнала ТУ.
		/// </summary>
		// https://rm.mfc.ru/issues/40270 29.07.2020 imironov
		public static readonly DateTime ClientNotificationHideDate = DateTime.Parse("2020-07-29 00:00:00.000");
    }
}
