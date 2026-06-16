using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DataCharacter", menuName = "ScriptableObjects/DataCharacter", order = 1)]
public class DataCharacter : ScriptableObject
{
    public GenderData[] genderData = new GenderData[]
    {
        new GenderData("Мужчина", 0),
        new GenderData("Женщина", 0),
        new GenderData("Трансгендер", 0)
    };

    public AgeGroup[] ageGroups = new AgeGroup[]
    {
        new AgeGroup(10, 15, -2),
        new AgeGroup(16, 25, 1),
        new AgeGroup(26, 40, 3),
        new AgeGroup(41, 60, 1),
        new AgeGroup(61, 80, -2)
    };

    public HealthTrait[] healthTraits = new HealthTrait[]
    {
        new HealthTrait("Здоров", 3),
        new HealthTrait("Альбинос", -1),
        new HealthTrait("Рахит", -3),
        new HealthTrait("Страдает ожирением", -3),
        new HealthTrait("Астма", -3),
        new HealthTrait("Близорукость", -2),
        new HealthTrait("Плоскостопие", -1),
        new HealthTrait("Атлетичный", 3),
        new HealthTrait("Проворный", 3),
        new HealthTrait("Выносливый", 3),
        new HealthTrait("Зоркий", 3),
        new HealthTrait("Храпун", -1)
    };

    public PersonalityTrait[] personalityTraits = new PersonalityTrait[]
    {
        new PersonalityTrait("Параноик", -1),
        new PersonalityTrait("Наивный", -1),
        new PersonalityTrait("Добряк", 1),
        new PersonalityTrait("Садист", -1),
        new PersonalityTrait("Вуайерист", -1),
        new PersonalityTrait("Флегматик", 1),
        new PersonalityTrait("Книжный червь", 0),
        new PersonalityTrait("Авантюрист", 2),
        new PersonalityTrait("Перфекционист", 0),
        new PersonalityTrait("Нытик", -1)
    };

    public Phobia[] phobias = new Phobia[]
    {
        new Phobia("Англофобия (Англии и всего английского)", 0),
        new Phobia("Сидерофобия (Боязнь звёзд)", -1),
        new Phobia("Паразитофобия", -1),
        new Phobia("Бленнофобия (боязнь слизи)", -1),
        new Phobia("Томофобия (боязнь хирургических операций)", -1),
        new Phobia("Талассофобия (Моря)", 0),
        new Phobia("Бесстрашный (боится только себя)", 1)
    };

    public Mania[] manias = new Mania[]
    {
        new Mania("Алкоголизм", -3),
        new Mania("Эмплеомания (стремление занять высокий пост)", -1),
        new Mania("Вопросомания", 0),
        new Mania("Софомания (убежденность в своем исключительном интеллекте)", -3),
        new Mania("Абуломания (патологическая нерешительность)", -4),
        new Mania("Дикемания (навязчивый интерес к судебным процессам)", 0),
        new Mania("Техномания", -1)
    };

    public Profession[] professions = new Profession[]
    {
        new Profession("Корпоративный юрист", -5),
        new Profession("Сотрудник службы безопасности", 6),
        new Profession("Учёный", 5),
        new Profession("Строитель", 3),
        new Profession("Колонист", 2),
        new Profession("Борт-механик", 6),
        new Profession("Пилот", 3),
        new Profession("Чернорабочий", 2),
        new Profession("Повар", 1),
        new Profession("Преступник", 0)
    };
    
    public Equipment[] equipment = new Equipment[]
    {
        new Equipment("Импульсный пистолет", 4),
        new Equipment("Энергетический батончик", 1),
        new Equipment("Полное собрание сочинений Айзека Азимова", 0),
        new Equipment("Карта-доступа", 5),
        new Equipment("Ремонтный гель \"Тяп-Ляп\"", 3),
        new Equipment("Био-сканер", 5),
        new Equipment("Гель для укладки волос", 0),
        new Equipment("Пачка никотиновой жвачки (без никотина)", 0),
        new Equipment("Портативная консоль", 0),
        new Equipment("Презервативы", 0),
        new Equipment("Дорожный набор для игры в \"Гоблины и Гроты\"", 0),
        new Equipment("Счастливая монетка", 0),
        new Equipment("Тюбик лавандового рафа", 0)
    };

    
   public Knowledge[] knowledges = new Knowledge[]
   {
       new Knowledge("Знает код от арсенала", 5),
       new Knowledge("Знает пароль от медицинского модуля", 4),
       new Knowledge("Знает как переделать сварочный аппарат в огнемет", 4),
       new Knowledge("Знает столицы всех штатов Америки", 0),
       new Knowledge("Знает, кто спит с Капитаном", 0),
       new Knowledge("Знает все сезоны сериала \"Ковбой Пипоп\"", 0),
       new Knowledge("Знает сюжет последней книги Джорджа Мартина", 0),
       new Knowledge("Быстро собирает кубик-рубика", 0),
       new Knowledge("Знает рецепт Космической Паэльи", 1),
       new Knowledge("Знает кто выжил в конце \"Драйва\"", 0),
       new Knowledge("Знает, где достать фильмы на белорусском", 0),
       new Knowledge("Знает рецепт лавандового рафа", 0)
   };
   
   
   ScenarioLocation[] scenarioLocations = new ScenarioLocation[]
   {
       // Сценарий 1
       new ScenarioLocation(1, "Кают-кампания", 1),
       new ScenarioLocation(1, "Спортзал", 2),
       new ScenarioLocation(1, "Раздатчик лавандового рафа", 0),
       new ScenarioLocation(1, "Отсек гидропоники", 6),
       new ScenarioLocation(1, "Грузовая палуба", 3),
       new ScenarioLocation(1, "Стыковочный шлюз №69", -1),
       new ScenarioLocation(1, "Кладовая ополаскивателя для рта", 0),
       new ScenarioLocation(1, "Ремонтный отсек", 6),

       // Сценарий 2
       new ScenarioLocation(2, "Гостиная с камином", 1),
       new ScenarioLocation(2, "Спальня", 0),
       new ScenarioLocation(2, "Подвал", -4),
       new ScenarioLocation(2, "Библиотека", 5),
       new ScenarioLocation(2, "Чердак", -3),
       new ScenarioLocation(2, "Чулан с коллекцией шляп", -1),
       new ScenarioLocation(2, "Детская комната", -3),
       new ScenarioLocation(2, "Кухня", 3),
       new ScenarioLocation(2, "Ванная", 1)
   };
   
   
    Scenario[] scenarios = new Scenario[]
    {
        new Scenario(1, "На борту \"Тесея\"",
            "2115 год, Земля задыхается от аномальных пыльных бурь, вызванных изменениями климата. " +
            "Ваша команда — последняя надежда Человечества, отправившаяся на корабле \"Тесей\" в поисках нового дома. " +
            "После долгого перелёта Вы приходите в себя в зале гибернации и замечаете, что большая часть капсул экипажа " +
            "пуста или испорчена, в центре зала лежит разорванный труп в форме капитана, научный модуль — отстыкован, " +
            "а бортовой компьютер \"Василиск Роко\" извещает Вас о запуске Протокола 8020. Судя по записям в судовом журнале " +
            "на борт проникла инородная, мимикрирующая под обычных людей инопланетная форма жизни. И Вы — сырье для ЕЕ НОВОГО ДОМА.\n\n" +
            "Теперь Ваша задача собрать команду, чтобы организовать оборону на корме корабля, а, по возможности, и потом дать тварям отпор, " +
            "но помните — заражённые могут быть и среди Вас! Запасов и топлива, чтобы дождаться спасательного корабля на всех Вас не хватит, " +
            "а с инопланетными чудовищами на борту Вы точно не сможете вернуться на Землю. Нужно дождаться помощи. Но доживёте ли Вы до нее? " +
            "Уж точно не Все... Время тянуть соломинки.", 40),

        new Scenario(2, "Дом Хоббса",
            "Дом Хоббса — пугающее место, дурная слава о котором уже многие годы не сходит с полом жёлтых газет. " +
            "Одержимый демоном Альберт Хоббс перебил всю свою семью, а после — загадочным образом исчез. С тех пор его зловещий особняк " +
            "вот уже 30 лет переходит из рук в руки, а надолго задержавшиеся там люди всегда заканчивают свой земной путь загадочными, " +
            "жуткими смертями. Вы все волею случая оказались в проклятом особняке Хоббса и вынуждены дать бой потустороннему кошмару. " +
            "К несчастью, ритуал, найденный Вами в какой-то из древних книг был проведен с ошибками, вместо изгнания демон пробудился ото сна " +
            "и явился по Ваши души. Двери и окна не поддаются, а из темных углов до Вас доносится зловещий глас, сотканный из десятков других голосов. " +
            "Жестокая сущность готова отпустить Вас с миром, но не за просто так! Ей нужна свежая кровь, чтобы покинуть свою обитель... " +
            "Вам придется оставить несколько своих товарищей в жертву темному духу, чтобы вырваться из дома и получить хотя бы призрачный шанс " +
            "провести повторный ритуал изгнания за порогом дома. Не всем из Вас сегодня суждено выжить, и далеко не факт, что даже выбравшись из дома " +
            "Вы сможете уберечь близлежащий город от вторжения потустороннего зла. Но и идей получше у Вас нет. Кто же получит шанс выбраться " +
            "из кошмарного дома и положить конец бесчинствам демона? Решать только Вам.", 35)
    };
   
    
    public Person[] persons = new Person[]
    {
        // Мужчины
        new Person("Адам", Gender.Male),
        new Person("Александр", Gender.Male),
        new Person("Алексей", Gender.Male),
        new Person("Али", Gender.Male),
        new Person("Андрей", Gender.Male),
        new Person("Арсен", Gender.Male),
        new Person("Ахмед", Gender.Male),
        new Person("Вэйдун", Gender.Male),
        new Person("Вэньмин", Gender.Male),
        new Person("Гарри", Gender.Male),
        new Person("Генрих", Gender.Male),
        new Person("Герберт", Gender.Male),
        new Person("Даниэль", Gender.Male),
        new Person("Джейкоб", Gender.Male),
        new Person("Джон", Gender.Male),
        new Person("Дмитрий", Gender.Male),
        new Person("Доминик", Gender.Male),
        new Person("Дэвид", Gender.Male),
        new Person("Дэшэн", Gender.Male),
        new Person("Евгений", Gender.Male),
        new Person("Иван", Gender.Male),
        new Person("Искандер", Gender.Male),
        new Person("Леон", Gender.Male),
        new Person("Марат", Gender.Male),
        new Person("Марсель", Gender.Male),
        new Person("Мартин", Gender.Male),
        new Person("Михаил", Gender.Male),
        new Person("Мухаммед", Gender.Male),
        new Person("Оливер", Gender.Male),
        new Person("Роберт", Gender.Male),
        new Person("Родриго", Gender.Male),
        new Person("Ролан", Gender.Male),
        new Person("Сергей", Gender.Male),
        new Person("Сунлинь", Gender.Male),
        new Person("Теодор", Gender.Male),
        new Person("Умар", Gender.Male),
        new Person("Ханс", Gender.Male),
        new Person("Чарли", Gender.Male),
        new Person("Чэнь", Gender.Male),
        new Person("Эмиль", Gender.Male),

        // Женщины
        new Person("Агнесса", Gender.Female),
        new Person("Айлин", Gender.Female),
        new Person("Айша", Gender.Female),
        new Person("Амина", Gender.Female),
        new Person("Анастасия", Gender.Female),
        new Person("Анджелина", Gender.Female),
        new Person("Анна", Gender.Female),
        new Person("Асылым", Gender.Female),
        new Person("Берта", Gender.Female),
        new Person("Божена", Gender.Female),
        new Person("Валентина", Gender.Female),
        new Person("Варвара", Gender.Female),
        new Person("Виктория", Gender.Female),
        new Person("Дженнифер", Gender.Female),
        new Person("Екатерина", Gender.Female),
        new Person("Елена", Gender.Female),
        new Person("Изабелла", Gender.Female),
        new Person("Карен", Gender.Female),
        new Person("Кармела", Gender.Female),
        new Person("Майя", Gender.Female),
        new Person("Мария", Gender.Female),
        new Person("Марта", Gender.Female),
        new Person("Марьям", Gender.Female),
        new Person("Медина", Gender.Female),
        new Person("Миранда", Gender.Female),
        new Person("Мэйли", Gender.Female),
        new Person("Нэлли", Gender.Female),
        new Person("Ольга", Gender.Female),
        new Person("Роза", Gender.Female),
        new Person("Саманта", Gender.Female),
        new Person("Селена", Gender.Female),
        new Person("София", Gender.Female),
        new Person("Сяо", Gender.Female),
        new Person("Татьяна", Gender.Female),
        new Person("Томирис", Gender.Female),
        new Person("Хадиша", Gender.Female),
        new Person("Цзин", Gender.Female),
        new Person("Цзы", Gender.Female),
        new Person("Шерон", Gender.Female),
        new Person("Ши", Gender.Female)
    };
    
    public Surname[] surnames = new Surname[]
    {
        new Surname("Абдуллаев"),
        new Surname("Акаев"),
        new Surname("Али"),
        new Surname("Беридзе"),
        new Surname("Браун"),
        new Surname("Ван"),
        new Surname("Виноградов"),
        new Surname("Гарсия"),
        new Surname("Гелашвили"),
        new Surname("Гонзалес"),
        new Surname("Григорян"),
        new Surname("Грубер"),
        new Surname("Деви"),
        new Surname("Делимханов"),
        new Surname("Демир"),
        new Surname("Иванов"),
        new Surname("Йылмаз"),
        new Surname("Ким"),
        new Surname("Кузнецов"),
        new Surname("Кумар"),
        new Surname("Лебедев"),
        new Surname("Ли"),
        new Surname("Малик"),
        new Surname("Мартен"),
        new Surname("Мельник"),
        new Surname("Мередит"),
        new Surname("Мёрфи"),
        new Surname("Мур"),
        new Surname("Мюллер"),
        new Surname("Нгуен"),
        new Surname("Новак"),
        new Surname("Патель"),
        new Surname("Пехлеви"),
        new Surname("Питерс"),
        new Surname("Попов"),
        new Surname("Робинсон"),
        new Surname("Родригес"),
        new Surname("Росси"),
        new Surname("Саркисян"),
        new Surname("Сато"),
        new Surname("Сильва"),
        new Surname("Смирнов"),
        new Surname("Смит"),
        new Surname("Соколов"),
        new Surname("Тейлор"),
        new Surname("Томас"),
        new Surname("Уайт"),
        new Surname("Хансен"),
        new Surname("Харрис"),
        new Surname("Чжан"),
        new Surname("Чэнь"),
        new Surname("Шарма"),
        new Surname("Эрнандес")
    };


    public CharacterCard GetCharacterCard()
    {
        CharacterCard result = new CharacterCard()
        {
            person = persons[Random.Range(0, persons.Length)],
            surName = surnames[Random.Range(0, surnames.Length)],
            genderData = genderData[Random.Range(0, genderData.Length)],
            ageGroup = ageGroups[Random.Range(0, ageGroups.Length)],
            healthTrait = healthTraits[Random.Range(0, healthTraits.Length)],
            personalityTrait = personalityTraits[Random.Range(0, personalityTraits.Length)],
            phoBia = phobias[Random.Range(0, phobias.Length)],
            mania = manias[Random.Range(0, manias.Length)],
            profession = professions[Random.Range(0, professions.Length)],
            equipment = equipment[Random.Range(0, equipment.Length)],
            knowledge = knowledges[Random.Range(0, knowledges.Length)]
        };
        return result;
    }
    
}
