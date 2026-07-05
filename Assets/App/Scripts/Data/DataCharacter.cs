using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;


[CreateAssetMenu(fileName = "DataCharacter", menuName = "ScriptableObjects/DataCharacter", order = 1)]
public class DataCharacter : ScriptableObject
{
    public GenderData[] genderData = new GenderData[]
    {
        new GenderData("Мужчина", 0, Gender.Male),
        new GenderData("Женщина", 0, Gender.Female),
        new GenderData("Трансгендер", 0,Gender.Trans)
    };

    public RaceData[] raceData = new RaceData[]
    {
        new RaceData(1,"Человек", Race.Human),
        new RaceData(2,"Человек", Race.Human),
        new RaceData(1,"Мимик", Race.Mimic),
        new RaceData(2,"Демон", Race.Demon)
    };

   public DataIconPerson dataIconPerson;

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
        new Profession(1, "Корпоративный юрист", -5),
        new Profession(1,"Сотрудник службы безопасности", 6),
        new Profession(1,"Учёный", 5),
        new Profession(1,"Строитель", 3),
        new Profession(1,"Колонист", 2),
        new Profession(1,"Борт-механик", 6),
        new Profession(1,"Пилот", 3),
        new Profession(1,"Чернорабочий", 2),
        new Profession(1,"Повар", 1),
        new Profession(1,"Преступник", 0),
        
        new Profession(2,"Священник", 5),
        new Profession(2,"Репортёр", 1),
        new Profession(2,"Демонолог", 7),
        new Profession(2,"Патрульный", 3),
        new Profession(2,"Бродяга", 2),
        new Profession(2,"Риэлтор", -1),
        new Profession(2,"Домовладелец", 2),
        new Profession(2,"Недовольный сосед", 0),
        new Profession(2,"Блогер", 0),
        new Profession(2,"Парапсихолог", 4)
    };
    
    public Equipment[] equipment = new Equipment[]
    {
        new Equipment(1,"Импульсный пистолет", 4),
        new Equipment(1,"Энергетический батончик", 1),
        new Equipment(1,"Полное собрание сочинений Айзека Азимова", 0),
        new Equipment(1,"Карта-доступа", 5),
        new Equipment(1,"Ремонтный гель \"Тяп-Ляп\"", 3),
        new Equipment(1,"Био-сканер", 5),
        new Equipment(1,"Гель для укладки волос", 0),
        new Equipment(1,"Пачка никотиновой жвачки (без никотина)", 0),
        new Equipment(1,"Портативная консоль", 0),
        new Equipment(1,"Презервативы", 0),
        new Equipment(1,"Дорожный набор для игры в \"Гоблины и Гроты\"", 0),
        new Equipment(1,"Счастливая монетка", 0),
        new Equipment(1,"Тюбик лавандового рафа", 0),
        
        new Equipment(2,"Некрономикон (на латыни)", 4),
        new Equipment(2,"Термос с лавандовым рафомафом", 0),
        new Equipment(2,"Мел", 2),
        new Equipment(2,"Три мешка соли", 5),
        new Equipment(2,"Футболка AC/DC", 0),
        new Equipment(2,"Зловещая кукла", -3),
        new Equipment(2,"Свиное ухо", 1),
        new Equipment(2,"Чек из \"Паранормально и точка\"", 0),
        new Equipment(2,"Водяной пистолет (вода освещена)", 5),
        new Equipment(2,"Фальшивая Библия Короля Якова", 0),
        new Equipment(2,"Набор ритуальных свечей", 2),
        new Equipment(2,"Эскиз защитного символа", 2),
        new Equipment(2,"Пачка снеков \"Дьявольский ожог\"", 0)
    };

    
   public Knowledge[] knowledges = new Knowledge[]
   {
       new Knowledge(1,"Знает код от арсенала", 5),
       new Knowledge(1,"Знает пароль от медицинского модуля", 4),
       new Knowledge(1,"Знает как переделать сварочный аппарат в огнемет", 4),
       new Knowledge(1,"Знает столицы всех штатов Америки", 0),
       new Knowledge(1,"Знает, кто спит с Капитаном", 0),
       new Knowledge(1,"Знает все сезоны сериала \"Ковбой Пипоп\"", 0),
       new Knowledge(1,"Знает сюжет последней книги Джорджа Мартина", 0),
       new Knowledge(1,"Быстро собирает кубик-рубика", 0),
       new Knowledge(1,"Знает рецепт Космической Паэльи", 1),
       new Knowledge(1,"Знает кто выжил в конце \"Драйва\"", 0),
       new Knowledge(1,"Знает, где достать фильмы на белорусском", 0),
       new Knowledge(1,"Знает рецепт лавандового рафа", 0),
       
       new Knowledge(2,"Знает настоящее имя демона", 3),
       new Knowledge(2,"Знает наизусть песню \"Проклятый старый дом\"", 0),
       new Knowledge(2,"Знает, где прошлый хозяин прятал виски", 0),
       new Knowledge(2,"Смотрел все сезоны \"Супернатуралов\"", 0),
       new Knowledge(2,"Помнит полную биографию Папы Римского", 0),
       new Knowledge(2,"Помнит все штампы из книг С. Кинга", 0),
       new Knowledge(2,"Знает цену проклятого дома", 0),
       new Knowledge(2,"Знает, что все делали прошлым летом", 1),
       new Knowledge(2,"Знает латынь", 2),
       new Knowledge(2,"Знает наизусть ритуал изгнания", 2),
       new Knowledge(2,"Знает фокус с монеткой", 0),
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

    // Enum для типа персонажа
    public enum CharacterRoleType
    {
        Human,      // Человек
        Mimic,      // Мимик (Сценарий 1)
        Possessed   // Одержимый (Сценарий 2)
    }
    
    [System.Serializable]
    public class CharacterRole
    {
        public int Scenario;              // Номер сценария (1 или 2)
        public CharacterRoleType RoleType; // Тип роли
        public string RoleName;            // Название роли
        public string Description;         // Описание роли
        public int Value;                  // Значение (0 для человека, -20 для заражённого)
    
        public CharacterRole(int scenario, CharacterRoleType roleType, string roleName, string description, int value)
        {
            Scenario = scenario;
            RoleType = roleType;
            RoleName = roleName;
            Description = description;
            Value = value;
        }
    }

// Создание массива ролей:
    CharacterRole[] characterRoles = new CharacterRole[]
    {
        // ========== Сценарий 1 ==========
        new CharacterRole(1, CharacterRoleType.Human, "Человек",
            "Вы оказались в числе немногих, чудом спасшихся на борту \"Тесея\". Теперь Ваша задача — выжить. Любой ценой.",
            0),
    
        new CharacterRole(1, CharacterRoleType.Mimic, "Мимик",
            "Вы заражены! Неизвестно как и когда это случилось, но теперь Ваша задача — во чтобы то ни стало остаться " +
            "в команде выживших, чтобы потом принести свою благодать на Землю...",
            -20),
    
        // ========== Сценарий 2 ==========
        new CharacterRole(2, CharacterRoleType.Human, "Человек",
            "Вы простой смертный. Выберетесь из дома во чтобы то ни стало, чтобы успеть до рассвета провести новый ритуал и изгнать демона.",
            0),
    
        new CharacterRole(2, CharacterRoleType.Possessed, "Одержимый",
            "Внешне Вы всё ещё человек, но внутри — Вы уже слуга тёмного многоликого божества. Притворитесь здравомыслящим " +
            "и выберетесь из дома, чтобы помешать новому ритуалу изгнания. Ваш владыка должен вырваться на свободу!",
            -20)
    };
    

    public CharacterCard GetCharacterCard(int scenario)
    {
        CharacterCard result = new CharacterCard();
        result.gender = genderData[Random.Range(0, genderData.Length)];
        result.raceData = raceData.GetRandomByScenario(scenario);
        result.iconPerson = dataIconPerson.icons.GetRandomIcon(scenario, result.gender.gender, result.raceData.race);
        result.person = persons.GetRandomByGender(result.gender.gender);
        result.surName = surnames[Random.Range(0, surnames.Length)];
        result.ageGroup = ageGroups[Random.Range(0, ageGroups.Length)];
        result.healthTrait = healthTraits[Random.Range(0, healthTraits.Length)];
        result.personalityTrait = personalityTraits[Random.Range(0, personalityTraits.Length)];
        result.phoBia = phobias[Random.Range(0, phobias.Length)];
        result.mania = manias[Random.Range(0, manias.Length)];
        result.profession = professions.GetRandomByScenario(scenario, p => p.scenario);
        result.equipment = equipment.GetRandomByScenario(scenario, e => e.scenario);
        result.knowledge = knowledges.GetRandomByScenario(scenario, k => k.scenario);
        return result;
    }
    
}
