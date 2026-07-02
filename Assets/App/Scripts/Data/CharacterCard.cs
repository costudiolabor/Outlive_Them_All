using System;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class CharacterCard {
    public Person person;
    public Surname surName;
    public GenderData gender;
    public RaceData raceData;
    public IconPerson iconPerson;
    public AgeGroup ageGroup;
    public HealthTrait healthTrait;
    public PersonalityTrait personalityTrait;
    public Phobia phoBia;
    public Mania mania;
    public Profession profession;
    public Equipment equipment;
    public Knowledge knowledge;
}

[Serializable]
public class GenderData {
    public string name;
    public Gender gender;
    public int value;

    public GenderData(string name, int value, Gender gender)
    {
        this.name = name;
        this.gender = gender;
        this.value = value;
    }
}

//public void Setup 
//characterCard.ge
// Использование:
// GenderData[] data = new GenderData[]
// {
//     new GenderData { Name = "Мужчина", Value = 0 },
//     new GenderData { Name = "Женщина", Value = 0 },
//     new GenderData { Name = "Трансгендер", Value = 0 }
// };

[Serializable]
public enum Race {
    Human,
    Mimic,
    Demon
}

[Serializable]
public class RaceData {
    public int scenarioCount;
    public string name;
    public Race race;

    public RaceData(int scenarioCount, string name, Race race)
    {
        this.scenarioCount = scenarioCount;
        this.name = name;
        this.race = race;
    }
}


[Serializable]
public class IconPerson
{
    public int scenarioCount;
    public Gender gender;
    public Race race;
    public Texture icon;
}

[Serializable]
public class AgeGroup {
    public int minAge;
    public int maxAge;
    public int value;
    
    public AgeGroup(int min, int max, int value)
    {
        minAge = min;
        maxAge = max;
        this.value = value;
    }
    
    public bool ContainsAge(int age) { return age >= minAge && age <= maxAge; }
    
    // Создание массива:
// AgeGroup[] ageGroups = new AgeGroup[]
// {
//     new AgeGroup(10, 15, -2),
//     new AgeGroup(16, 25, 1),
//     new AgeGroup(26, 40, 3),
//     new AgeGroup(41, 60, 1),
//     new AgeGroup(61, 80, -2)
// };
//
// // Пример использования:
// int playerAge = 30;
// foreach (var group in ageGroups)
// {
//     if (group.ContainsAge(playerAge))
//     {
//         Debug.Log($"Бонус для возраста {playerAge}: {group.value}");
//         break;
//     }
// }

}

[Serializable]
public class HealthTrait {
    public string name;
    public int value;

    public HealthTrait(string name, int value)
    {
        this.name = name;
        this.value = value;
    }
    
// Создание массива:
// HealthTrait[] healthTraits = new HealthTrait[]
// {
//     new HealthTrait("Здоров", 3),
//     new HealthTrait("Альбинос", -1),
//     new HealthTrait("Рахит", -3),
//     new HealthTrait("Страдает ожирением", -3),
//     new HealthTrait("Астма", -3),
//     new HealthTrait("Близорукость", -2),
//     new HealthTrait("Плоскостопие", -1),
//     new HealthTrait("Атлетичный", 3),
//     new HealthTrait("Проворный", 3),
//     new HealthTrait("Выносливый", 3),
//     new HealthTrait("Зоркий", 3),
//     new HealthTrait("Храпун", -1)
// };
}


[Serializable]
public class PersonalityTrait {
    public string name;
    public int value;

    public PersonalityTrait(string name, int value)
    {
        this.name = name;
        this.value = value;
    }
}


// Создание массива:
// PersonalityTrait[] personalityTraits = new PersonalityTrait[]
// {
//     new PersonalityTrait("Параноик", -1),
//     new PersonalityTrait("Наивный", -1),
//     new PersonalityTrait("Добряк", 1),
//     new PersonalityTrait("Садист", -1),
//     new PersonalityTrait("Вуайерист", -1),
//     new PersonalityTrait("Флегматик", 1),
//     new PersonalityTrait("Книжный червь", 0),
//     new PersonalityTrait("Авантюрист", 2),
//     new PersonalityTrait("Перфекционист", 0),
//     new PersonalityTrait("Нытик", -1)
// };



[Serializable]
public class Phobia {
    public string name;
    public int value;

    public Phobia(string name, int value)
    {
        this.name = name;
        this.value = value;
    }
}

// Создание массива:
// Phobia[] phobias = new Phobia[]
// {
//     new Phobia("Англофобия (Англии и всего английского)", 0),
//     new Phobia("Сидерофобия (Боязнь звёзд)", -1),
//     new Phobia("Паразитофобия", -1),
//     new Phobia("Бленнофобия (боязнь слизи)", -1),
//     new Phobia("Томофобия (боязнь хирургических операций)", -1),
//     new Phobia("Талассофобия (Моря)", 0),
//     new Phobia("Бесстрашный (боится только себя)", 1)
// };


[Serializable]
public class Mania {
    public string name;
    public int value;

    public Mania(string name, int value)
    {
        this.name = name;
        this.value = value;
    }
}

// Создание массива:
// Mania[] manias = new Mania[]
// {
//     new Mania("Алкоголизм", -3),
//     new Mania("Эмплеомания (стремление занять высокий пост)", -1),
//     new Mania("Вопросомания", 0),
//     new Mania("Софомания (убежденность в своем исключительном интеллекте)", -3),
//     new Mania("Абуломания (патологическая нерешительность)", -4),
//     new Mania("Дикемания (навязчивый интерес к судебным процессам)", 0),
//     new Mania("Техномания", -1)
// };


[Serializable]
public class Profession {
    public int scenario;
    public string name;
    public int value;

    public Profession (int scenario, string name, int value)
    {
        this.scenario = scenario;
        this.name = name;
        this.value = value;
    }
}

// Создание массива:
// Profession[] professions = new Profession[]
// {
//     new Profession("Корпоративный юрист", -5),
//     new Profession("Сотрудник службы безопасности", 6),
//     new Profession("Учёный", 5),
//     new Profession("Строитель", 3),
//     new Profession("Колонист", 2),
//     new Profession("Борт-механик", 6),
//     new Profession("Пилот", 3),
//     new Profession("Чернорабочий", 2),
//     new Profession("Повар", 1),
//     new Profession("Преступник", 0)
// };
    

[Serializable]
public class Equipment {
    public int scenario;
    public string name;
    public int value;

    public Equipment (int scenario, string name, int value)
    {
        this.scenario = scenario;
        this.name = name;
        this.value = value;
    }
}

// Создание массива:
// Equipment[] equipment = new Equipment[]
// {
//     new Equipment("Импульсный пистолет", 4),
//     new Equipment("Энергетический батончик", 1),
//     new Equipment("Полное собрание сочинений Айзека Азимова", 0),
//     new Equipment("Карта-доступа", 5),
//     new Equipment("Ремонтный гель \"Тяп-Ляп\"", 3),
//     new Equipment("Био-сканер", 5),
//     new Equipment("Гель для укладки волос", 0),
//     new Equipment("Пачка никотиновой жвачки (без никотина)", 0),
//     new Equipment("Портативная консоль", 0),
//     new Equipment("Презервативы", 0),
//     new Equipment("Дорожный набор для игры в \"Гоблины и Гроты\"", 0),
//     new Equipment("Счастливая монетка", 0),
//     new Equipment("Тюбик лавандового рафа", 0)
// };


[Serializable]
public class Knowledge {
    public int scenario;
    public string name;
    public int value;

    public Knowledge (int scenario, string name, int value)
    {
        this.scenario = scenario;
        this.name = name;
        this.value = value;
    }
}

// Создание массива:
// Knowledge[] knowledges = new Knowledge[]
// {
//     new Knowledge("Знает код от арсенала", 5),
//     new Knowledge("Знает пароль от медицинского модуля", 4),
//     new Knowledge("Знает как переделать сварочный аппарат в огнемет", 4),
//     new Knowledge("Знает столицы всех штатов Америки", 0),
//     new Knowledge("Знает, кто спит с Капитаном", 0),
//     new Knowledge("Знает все сезоны сериала \"Ковбой Пипоп\"", 0),
//     new Knowledge("Знает сюжет последней книги Джорджа Мартина", 0),
//     new Knowledge("Быстро собирает кубик-рубика", 0),
//     new Knowledge("Знает рецепт Космической Паэльи", 1),
//     new Knowledge("Знает кто выжил в конце \"Драйва\"", 0),
//     new Knowledge("Знает, где достать фильмы на белорусском", 0),
//     new Knowledge("Знает рецепт лавандового рафа", 0)
// };


[Serializable]
public class ScenarioLocation {
    public int scenario;
    public string location;
    public int value;

    public ScenarioLocation (int scenario, string location, int value)
    {
        this.scenario = scenario;
        this.location = location;
        this.value = value;
    }
}

// Создание массива:
// ScenarioLocation[] scenarioLocations = new ScenarioLocation[]
// {
//     // Сценарий 1
//     new ScenarioLocation(1, "Кают-кампания", 1),
//     new ScenarioLocation(1, "Спортзал", 2),
//     new ScenarioLocation(1, "Раздатчик лавандового рафа", 0),
//     new ScenarioLocation(1, "Отсек гидропоники", 6),
//     new ScenarioLocation(1, "Грузовая палуба", 3),
//     new ScenarioLocation(1, "Стыковочный шлюз №69", -1),
//     new ScenarioLocation(1, "Кладовая ополаскивателя для рта", 0),
//     new ScenarioLocation(1, "Ремонтный отсек", 6),
//     
//     // Сценарий 2
//     new ScenarioLocation(2, "Гостиная с камином", 1),
//     new ScenarioLocation(2, "Спальня", 0),
//     new ScenarioLocation(2, "Подвал", -4),
//     new ScenarioLocation(2, "Библиотека", 5),
//     new ScenarioLocation(2, "Чердак", -3),
//     new ScenarioLocation(2, "Чулан с коллекцией шляп", -1),
//     new ScenarioLocation(2, "Детская комната", -3),
//     new ScenarioLocation(2, "Кухня", 3),
//     new ScenarioLocation(2, "Ванная", 1)
// };


[Serializable]
public class Scenario {
    public int number;
    public string title;
    public string description;
    public int value;

    public Scenario (int number, string title, string description, int value)
    {
        this.number = number;
        this.title = title;
        this.description = description;
        this.value = value;
    }
    
}

// Создание массива:
// Scenario[] scenarios = new Scenario[]
// {
//     new Scenario(1, "На борту \"Тесея\"", 
//         "2115 год, Земля задыхается от аномальных пыльных бурь, вызванных изменениями климата. " +
//         "Ваша команда — последняя надежда Человечества, отправившаяся на корабле \"Тесей\" в поисках нового дома. " +
//         "После долгого перелёта Вы приходите в себя в зале гибернации и замечаете, что большая часть капсул экипажа " +
//         "пуста или испорчена, в центре зала лежит разорванный труп в форме капитана, научный модуль — отстыкован, " +
//         "а бортовой компьютер \"Василиск Роко\" извещает Вас о запуске Протокола 8020. Судя по записям в судовом журнале " +
//         "на борт проникла инородная, мимикрирующая под обычных людей инопланетная форма жизни. И Вы — сырье для ЕЕ НОВОГО ДОМА.\n\n" +
//         "Теперь Ваша задача собрать команду, чтобы организовать оборону на корме корабля, а, по возможности, и потом дать тварям отпор, " +
//         "но помните — заражённые могут быть и среди Вас! Запасов и топлива, чтобы дождаться спасательного корабля на всех Вас не хватит, " +
//         "а с инопланетными чудовищами на борту Вы точно не сможете вернуться на Землю. Нужно дождаться помощи. Но доживёте ли Вы до нее? " +
//         "Уж точно не Все... Время тянуть соломинки.", 40),
//     
//     new Scenario(2, "Дом Хоббса",
//         "Дом Хоббса — пугающее место, дурная слава о котором уже многие годы не сходит с полом жёлтых газет. " +
//         "Одержимый демоном Альберт Хоббс перебил всю свою семью, а после — загадочным образом исчез. С тех пор его зловещий особняк " +
//         "вот уже 30 лет переходит из рук в руки, а надолго задержавшиеся там люди всегда заканчивают свой земной путь загадочными, " +
//         "жуткими смертями. Вы все волею случая оказались в проклятом особняке Хоббса и вынуждены дать бой потустороннему кошмару. " +
//         "К несчастью, ритуал, найденный Вами в какой-то из древних книг был проведен с ошибками, вместо изгнания демон пробудился ото сна " +
//         "и явился по Ваши души. Двери и окна не поддаются, а из темных углов до Вас доносится зловещий глас, сотканный из десятков других голосов. " +
//         "Жестокая сущность готова отпустить Вас с миром, но не за просто так! Ей нужна свежая кровь, чтобы покинуть свою обитель... " +
//         "Вам придется оставить несколько своих товарищей в жертву темному духу, чтобы вырваться из дома и получить хотя бы призрачный шанс " +
//         "провести повторный ритуал изгнания за порогом дома. Не всем из Вас сегодня суждено выжить, и далеко не факт, что даже выбравшись из дома " +
//         "Вы сможете уберечь близлежащий город от вторжения потустороннего зла. Но и идей получше у Вас нет. Кто же получит шанс выбраться " +
//         "из кошмарного дома и положить конец бесчинствам демона? Решать только Вам.", 35)
// };


public enum Gender {
    Male,
    Female,
    Trans
}

[Serializable]
public class Person {
    public string name;
    public Gender gender;

    public Person (string name, Gender gender)
    {
        this.name = name;
        this.gender = gender;
    }
    
}

// Создание массива:
// Person[] persons = new Person[]
// {
//     // Мужчины
//     new Person("Адам", Gender.Male),
//     new Person("Александр", Gender.Male),
//     new Person("Алексей", Gender.Male),
//     new Person("Али", Gender.Male),
//     new Person("Андрей", Gender.Male),
//     new Person("Арсен", Gender.Male),
//     new Person("Ахмед", Gender.Male),
//     new Person("Вэйдун", Gender.Male),
//     new Person("Вэньмин", Gender.Male),
//     new Person("Гарри", Gender.Male),
//     new Person("Генрих", Gender.Male),
//     new Person("Герберт", Gender.Male),
//     new Person("Даниэль", Gender.Male),
//     new Person("Джейкоб", Gender.Male),
//     new Person("Джон", Gender.Male),
//     new Person("Дмитрий", Gender.Male),
//     new Person("Доминик", Gender.Male),
//     new Person("Дэвид", Gender.Male),
//     new Person("Дэшэн", Gender.Male),
//     new Person("Евгений", Gender.Male),
//     new Person("Иван", Gender.Male),
//     new Person("Искандер", Gender.Male),
//     new Person("Леон", Gender.Male),
//     new Person("Марат", Gender.Male),
//     new Person("Марсель", Gender.Male),
//     new Person("Мартин", Gender.Male),
//     new Person("Михаил", Gender.Male),
//     new Person("Мухаммед", Gender.Male),
//     new Person("Оливер", Gender.Male),
//     new Person("Роберт", Gender.Male),
//     new Person("Родриго", Gender.Male),
//     new Person("Ролан", Gender.Male),
//     new Person("Сергей", Gender.Male),
//     new Person("Сунлинь", Gender.Male),
//     new Person("Теодор", Gender.Male),
//     new Person("Умар", Gender.Male),
//     new Person("Ханс", Gender.Male),
//     new Person("Чарли", Gender.Male),
//     new Person("Чэнь", Gender.Male),
//     new Person("Эмиль", Gender.Male),
//     
//     // Женщины
//     new Person("Агнесса", Gender.Female),
//     new Person("Айлин", Gender.Female),
//     new Person("Айша", Gender.Female),
//     new Person("Амина", Gender.Female),
//     new Person("Анастасия", Gender.Female),
//     new Person("Анджелина", Gender.Female),
//     new Person("Анна", Gender.Female),
//     new Person("Асылым", Gender.Female),
//     new Person("Берта", Gender.Female),
//     new Person("Божена", Gender.Female),
//     new Person("Валентина", Gender.Female),
//     new Person("Варвара", Gender.Female),
//     new Person("Виктория", Gender.Female),
//     new Person("Дженнифер", Gender.Female),
//     new Person("Екатерина", Gender.Female),
//     new Person("Елена", Gender.Female),
//     new Person("Изабелла", Gender.Female),
//     new Person("Карен", Gender.Female),
//     new Person("Кармела", Gender.Female),
//     new Person("Майя", Gender.Female),
//     new Person("Мария", Gender.Female),
//     new Person("Марта", Gender.Female),
//     new Person("Марьям", Gender.Female),
//     new Person("Медина", Gender.Female),
//     new Person("Миранда", Gender.Female),
//     new Person("Мэйли", Gender.Female),
//     new Person("Нэлли", Gender.Female),
//     new Person("Ольга", Gender.Female),
//     new Person("Роза", Gender.Female),
//     new Person("Саманта", Gender.Female),
//     new Person("Селена", Gender.Female),
//     new Person("София", Gender.Female),
//     new Person("Сяо", Gender.Female),
//     new Person("Татьяна", Gender.Female),
//     new Person("Томирис", Gender.Female),
//     new Person("Хадиша", Gender.Female),
//     new Person("Цзин", Gender.Female),
//     new Person("Цзы", Gender.Female),
//     new Person("Шерон", Gender.Female),
//     new Person("Ши", Gender.Female)
// };


[Serializable]
public class Surname {
    public string name;

    public Surname (string name)
    {
        this.name = name;
    }
}

// Создание массива:
// Surname[] surnames = new Surname[]
// {
//     new Surname("Абдуллаев"),
//     new Surname("Акаев"),
//     new Surname("Али"),
//     new Surname("Беридзе"),
//     new Surname("Браун"),
//     new Surname("Ван"),
//     new Surname("Виноградов"),
//     new Surname("Гарсия"),
//     new Surname("Гелашвили"),
//     new Surname("Гонзалес"),
//     new Surname("Григорян"),
//     new Surname("Грубер"),
//     new Surname("Деви"),
//     new Surname("Делимханов"),
//     new Surname("Демир"),
//     new Surname("Иванов"),
//     new Surname("Йылмаз"),
//     new Surname("Ким"),
//     new Surname("Кузнецов"),
//     new Surname("Кумар"),
//     new Surname("Лебедев"),
//     new Surname("Ли"),
//     new Surname("Малик"),
//     new Surname("Мартен"),
//     new Surname("Мельник"),
//     new Surname("Мередит"),
//     new Surname("Мёрфи"),
//     new Surname("Мур"),
//     new Surname("Мюллер"),
//     new Surname("Нгуен"),
//     new Surname("Новак"),
//     new Surname("Патель"),
//     new Surname("Пехлеви"),
//     new Surname("Питерс"),
//     new Surname("Попов"),
//     new Surname("Робинсон"),
//     new Surname("Родригес"),
//     new Surname("Росси"),
//     new Surname("Саркисян"),
//     new Surname("Сато"),
//     new Surname("Сильва"),
//     new Surname("Смирнов"),
//     new Surname("Смит"),
//     new Surname("Соколов"),
//     new Surname("Тейлор"),
//     new Surname("Томас"),
//     new Surname("Уайт"),
//     new Surname("Хансен"),
//     new Surname("Харрис"),
//     new Surname("Чжан"),
//     new Surname("Чэнь"),
//     new Surname("Шарма"),
//     new Surname("Эрнандес")
// };



[Serializable]
public enum EventEffectType {
    RV,           // РВ (Resource Value) - числовое изменение
    PlayerTransform, // Превращение игрока
    Neutral       // Нейтральное событие
}

[Serializable]
public class GameEvent {
    public int scenario;
    public string title;
    public EventEffectType EffectType;
    public int rvValue;
    public bool turnsPlayerIntoMimicOrPossessed;
    public string description;

    public GameEvent (int scenario, string title, EventEffectType effectType, int rvValue, bool turnsPlayerIntoMimicOrPossessed, string description)
    {
        
        this.scenario = scenario;
        this.title = title;
        this.EffectType = effectType;
        this.rvValue = rvValue;
        this.turnsPlayerIntoMimicOrPossessed = turnsPlayerIntoMimicOrPossessed;
        this.description = description;
    }
    
}

// Создание массива событий:
// GameEvent[] gameEvents = new GameEvent[]
// {
//     // ========== Сценарий 1 ==========
//     new GameEvent(1, "Поломка систем обогрева", EventEffectType.RV, -6, false,
//         "ИИ \"Василиск Роко\" извещает о повышении температуры в отсеках. Вам ничего не грозит, " +
//         "но такой резкий скачок ускорит процесс распространения заразы. Тварей на корабле станет больше."),
//     
//     new GameEvent(1, "Отключение основного освещения", EventEffectType.RV, -4, false,
//         "Внезапно весь свет в отсеках гаснет, а ему на смену приходят кроваво-красные отблески аварийных ламп. " +
//         "Кажется, кроме этой поломки пока ничего не произошло."),
//     
//     new GameEvent(1, "Вспышка звезды", EventEffectType.RV, -12, false,
//         "Вой сирены извещает Вас о вспышке на ближайшей звезде. Волна излучения накрывает \"Тесей\", " +
//         "вырубая большую часть систем. И прежде всего — защитные контуры жилых блоков. " +
//         "У жутких мимиков ещё больше шансов добраться до Вас."),
//     
//     new GameEvent(1, "Активация системы дезинфекции", EventEffectType.RV, 6, false,
//         "ИИ \"Василиск Роко\" извещает о запуске принудительной системы дезинфекции. Вам ничего не грозит. " +
//         "Системы корабля распыляют химикаты по всем \"грязным\" палубам судна, нанося ущерб мимикам. " +
//         "Кажется, Ваши шансы немного возросли."),
//     
//     new GameEvent(1, "Обновление протокола безопасности", EventEffectType.RV, 8, false,
//         "ИИ \"Василиск Роко\" извещает об обновлении протокола безопасности. На входе в незараженные отсеки " +
//         "оживают автоматические защитные турели. Зарядов в них немного, и все же, Ваши шансы выжить возросли."),
//     
//     new GameEvent(1, "Бунт ИИ \"Василиск Роко\"", EventEffectType.RV, -12, false,
//         "Корабельный ИИ \"Василиск Роко\" начинает сходить с ума. Он разблокировал часть дверей в \"грязной зоне\", " +
//         "взамен принудительно закрыв часть незараженных отсеков, отрезая Вам простор для маневра. " +
//         "Шансы мимиков перебить Вас возросли."),
//     
//     new GameEvent(1, "Система оповещения играет джаз", EventEffectType.Neutral, 0, false,
//         "Под потолком начинает разносится лёгкий мотив, приправленный густым мужским голосом. " +
//         "Самое время для джаза в этом стальном Аду! С другой стороны и ничего дурного пока не случилось. " +
//         "Танцуют все!"),
//     
//     new GameEvent(1, "Внеочередная порция лавандового Рафа", EventEffectType.Neutral, 0, false,
//         "ИИ \"Василиск Роко\" извещает о дне рождения покойного капитана Матиаса! Все члены экипажа могут " +
//         "проследовать к любому свободному раздатчику в столовой или кают-компании, чтобы испить свежий " +
//         "лавандовый раф в честь именника... А это точно поможет Вам выжить?"),
//     
//     new GameEvent(1, "Скрежет за переборкой...", EventEffectType.PlayerTransform, 0, true,
//         "За переборкой раздаётся леденящий душу скрежет. Вы в ужасе затихаете, оглянувшись в то место, " +
//         "откуда доносится звук. Спустя несколько минут все затихает. Пока все хорошо... Так ведь?"),
//     
//     new GameEvent(1, "Скрежет за переборкой", EventEffectType.Neutral, 0, false,
//         "За переборкой раздаётся леденящий душу скрежет. Вы в ужасе затихаете, оглянувшись в то место, " +
//         "откуда доносится звук. Спустя несколько минут все затихает. Пока все хорошо... Так ведь?"),
//     
//     // ========== Сценарий 2 ==========
//     new GameEvent(2, "Зловещий шепот во мраке...", EventEffectType.PlayerTransform, 0, true,
//         "В темных углах разливается жутковатый шепот, вероломно предлагая Вам блага, о каких только может " +
//         "мечтать простой смертный. Вам еле удается стряхнуть это наваждение и остаться в здравом уме. Или нет?.."),
//     
//     new GameEvent(2, "Зловещий шепот во мраке", EventEffectType.Neutral, 0, false,
//         "В темных углах разливается жутковатый шепот, вероломно предлагая Вам блага, о каких только может " +
//         "мечтать простой смертный. Вам еле удается стряхнуть это наваждение и остаться в здравом уме. Или нет?.."),
//     
//     new GameEvent(2, "Погасли свечи...", EventEffectType.PlayerTransform, 0, true,
//         "В помещение врывается дьявольский, пронизывающий до костей ветер — расставленные по комнате свечи " +
//         "начинают гаснуть одна за другой. Вы спешно зажигаете их снова, боясь навсегда остаться в непроглядной " +
//         "тьме и сберечь остатки своего благоразумия."),
//     
//     new GameEvent(2, "Погасли свечи", EventEffectType.Neutral, 0, false,
//         "В помещение врывается дьявольский, пронизывающий до костей ветер — расставленные по комнате свечи " +
//         "начинают гаснуть одна за другой. Вы спешно зажигаете их снова, боясь навсегда остаться в непроглядной " +
//         "тьме и сберечь остатки своего благоразумия."),
//     
//     new GameEvent(2, "Оживший грамофон", EventEffectType.RV, -4, false,
//         "Внезапно, в углу комнаты начинает визжать старый грамофон. Вместо музыки в Ваши уши забивается " +
//         "чудовищная какофония звуков, похожая на детский визг. Вы зажимаете уши, пытаясь уберечь свои разум " +
//         "и слух от кошмара, льющегося из ржавого раструба. Сосредоточиться все сложнее..."),
//     
//     new GameEvent(2, "Ожившая мебель", EventEffectType.RV, -6, false,
//         "Мебель взмывает к потолку и начинает безумным вихрем летать по комнатам, снося все на своем пути. " +
//         "Вы с воплями бросаетесь на пыльный пол, пытаясь уберечь себя. Когда все приходит в норму, " +
//         "Вы все изранены, избиты и ещё более нервозны. Сосредоточиться становится сложнее."),
//     
//     new GameEvent(2, "Разлетающиеся стекла", EventEffectType.RV, -10, false,
//         "Зеркала и окна разлетаются вдребезги от жуткого писка, потрясающего дом до самого фундамента. " +
//         "Острые как бритва осколки убийственным вихрем летят во все стороны. Льющаяся с Вас кровь мгновенно " +
//         "впитывается в дощатый пол, а в ушах застывает злорадный дьявольский смех. Демон шепчет, что Ваша " +
//         "кровь и ужас делают его сильнее..."),
//     
//     new GameEvent(2, "Пожар", EventEffectType.RV, -8, false,
//         "В центре комнаты загорается дьявольский огонь синего цвета. Вы в ужасе бросаетесь к стенам, " +
//         "пытаясь хотя бы отсрочить свою погибель. Внезапно пламя просто исчезает. Темный владыка сардонически " +
//         "смеётся: Ваши крики не только забавляют его, но и делают его сильнее."),
//     
//     new GameEvent(2, "Убывающая Луна", EventEffectType.RV, 5, false,
//         "Вы видите в одно из окон, что облака на небе расступились. Вы видите что Луна в эту ночь убывающая. " +
//         "Кажется, это хороший знак. Согласно поверьям, в такие ночи злые духи ослабевают."),
//     
//     new GameEvent(2, "Звёзды встали в ряд", EventEffectType.RV, 8, false,
//         "Вы вспоминаете, что сегодняшняя ночь крайне удачная для Вас, несмотря на весь творящийся кошмар. " +
//         "Сегодня звёзды встали в нужное положение, что может сделать Ваш ритуал изгнания гораздо сильнее! " +
//         "Осталось только выбраться из проклятого дома...")
// };


[Serializable]
public class Ending {
    public int scenario;
    public int value;
    public string title;
    public string description;

    public Ending(int scenario, int value, string title, string description)
    {
        this.scenario = scenario;
        this.value = value;
        this.title = title;
        this.description = description;
    }
}

// Создание массива концовок:
// Ending[] endings = new Ending[]
// {
//     // ========== Сценарий 1 ==========
//     new Ending(1, 0, "Никто не услышит",
//         "Вы надёжно барикадируетесь в безопасной части судна и пытаетесь прикинуть свои зыбкие шансы на выживание. " +
//         "Имеющегося у Вас снаряжения и припасов явно недостаточно, чтобы выдержать длительную осаду до прихода какой-либо помощи, " +
//         "ровно как и выжечь на \"Тесее\" всю инопланетную заразу. Криотоплива и запасов энергии для длительной работы капсул гибернации тоже нет. " +
//         "Вы уже слышите, как утробные звуки и скрежет когтей за переборками становятся все более отчётливыми. " +
//         "Вы переглядываетесь со своими товарищами по несчастью, понимая какое решение Вам предстоит принять — " +
//         "умереть мучительной смертью в лапах жутких мимиков, став частью их органического улья в реакторном зале \"Тесея\" " +
//         "или же добровольно лечь в холодный стеклянный гроб, уснув вечным сном, от которого никто из Вас уже не пробудится. " +
//         "И при любом раскладе среди звёзд никто не услышит Вашего крика..."),
//     
//     new Ending(1, 30, "Надежда не умирает",
//         "Вы блокируете все проходы, ведущие в незараженную часть судна и, для надёжности, дополнительно возводите перед дверями " +
//         "баррикады из научного оборудования и прочего, уже никому не нужного хлама. Остановит ли это их? Задержит хотя бы? " +
//         "Следующие 72 земных часа проходят в томительном ожидании, пока за переборками не начинает слышаться до боли знакомый скрежет " +
//         "и утробный визг! Они идут... Вы с трудом отбиваете их нападение, слаженно работая вместе и, наконец, можете выдохнуть. " +
//         "Реакторный зал все ещё заполнен органической субстанцией и туда, Вам, похоже, не пробиться. Но теперь эти твари точно к Вам не сунутся. " +
//         "Припасов и медикаментов впритык. Вы запускаете радиомаяк, и надёжно законсервировав поражённые инопланетной заразой отсеки, " +
//         "заканчиваете последние приготовления. Вся информация о заражении перенесена в судовой журнал, радиомаяк с предостережением и сигналом о помощи — запущен, " +
//         "а Вы — готовитесь лечь в гибернацию. Энергии и топлива для капсул остаётся не так много, но вероятно, помощь успеет к Вам. Или же нет?.. " +
//         "Как бы то ни было, Вы погружаетесь в анабиоз с надеждой у сердца и осознанием того, что сделали все, что могли."),
//     
//     new Ending(1, 60, "Живы будем — не помрем!",
//         "Припасов, оружия и умелых рук у Вас, кажется, достаточно. Пора дать бой... Шепча молитвы, шипя проклятия и лелея надежды, " +
//         "Вы совместно готовитесь к обороне в безопасной части \"Тесея\": блокируете двери и сооружаете баррикады, восстанавливаете системы защиты, " +
//         "организуете импровизированные ловушки. Инопланетный враг атакует после трёх земных суток мучительного ожидания."),
//     
//     new Ending(1, -10, "Среди овец",
//         "Вы уже чувствуете. Чувствуете их решимость. Их страх. Их смятение. Их надежду. Как же она сладко отзывается внутри Вас. " +
//         "Пока они ничего не заподозрили. Они реально надеются дать отпор Вам. Тем Вашим частям, которые таятся в других сотах их железного улья. " +
//         "Они верят Вам. И Вы готовы. Вы готовы стать Ими, а они станут Вами. Осталось недолго. Нет боли. Нет сомнений. Нет страха. " +
//         "Один разум. Одно сердце. Одна воля. \"ТЕСЕЙ\" — ВАШ ДОМ. И ИХ ДРУГОЙ УЛЕЙ СРЕДИ ЗВЁЗД, ТОЖЕ БУДЕТ ВАШИМ."),
//     
//     // ========== Сценарий 2 ==========
//     new Ending(2, 0, "Тьма и больше ничего!",
//         "Вам едва удается выбраться из дома перед самым рассветом. До Ваших ушей ещё доносятся крики кошмара покинутых товарищей " +
//         "и злобный хохот тысяч нечеловеческих голосов, стены дома будто сотрясают судороги, разнося вокруг чудовищный, шатающий саму земную твердь, скрип.\n\n" +
//         "Вы, тяжело дыша, переглядываетесь — времени до того, как первые лучи солнца падут на землю, осталось совсем мало. " +
//         "Вы спешно перебираете в уме все, что помните об изгнании злых духов и пытаетесь воссоздать ритуал в правильном порядке. " +
//         "Ваши сердца бьются в унисон, пока слова, слетающие с Ваших губ, сплетаются в текст очистительного заклинания. " +
//         "Пока земля продолжает содрогаться то ли от грохота, то ли от зловещего смеха, сам воздух словно электризуется... " +
//         "Как только Вы заканчиваете ритуал, землю озаряет рассветное солнце, а вокруг наступает тишина. Получилось? Неужели! " +
//         "Преждевременные светлые улыбки спадают с Ваших лиц, а в сердцах поселяется первобытный ужас, когда солнце застилает клубящееся темное облако. " +
//         "Безумный демонический хохот покидает стены дома и начинает растекаться по Вашему хрупкому разуму. " +
//         "Вы стремглав бросаетесь наутёк, оставляя проклятый дом позади... прямо в объятия застилавшей всё тьмы. И Вы — ее маленькие лоскутки. Навсегда."),
//     
//     new Ending(2, 30, "За миг до рассвета",
//         "Самый темный час всегда перед рассветом. И Вы его пережили. Пусть и не все. Принеся кровавую жертву, Вы покидаете кошмарный дом Хоббса " +
//         "и оказываетесь во влажных предрассветных сумерках. Лучи восходящего солнца медленно опаляют матовый горизонт — времени для того, " +
//         "чтобы провести новый ритуал изгнания, почти не осталось...\n\n" +
//         "Вы берётесь за руки и сбивчиво начинаете зачитывать древнее песнопение, пока дом содрогается, будто живой. " +
//         "Вы раз за разом, тщетно повторяете текст ритуала, пока сам зловещий особняк разражается гомерическим хохотом тысяч нечеловеческих голосов, " +
//         "в унисон хлопая дверями и оконными ставнями, будто крыльями. Когда же Вам в глаза бьют первые лучи солнца, наступает долгожданное затишье. " +
//         "В окнах всё ещё мелькают жуткие тени — демон остался здесь, в доме, но и в большой мир сил вырваться ему уже не хватит. " +
//         "Исчадие Ада всё ещё привязано к дому Хоббса и ожидает новых глупцов, которые попадутся в его жуткую ловушку. " +
//         "Вы навсегда покидаете это место, держа в своих душах мрачный секрет. Вам удалось уберечь безмятежно спящий город. Надолго ли? Неизвестно. " +
//         "В любом случае, какой бы ни была Ваша дальнейшая жизнь — она никогда не будет прежней."),
//     
//     new Ending(2, 60, "Кромешный свет",
//         "Вы заплатили свою кровавую цену. Некоторые Ваши товарищи навсегда брошены на съедение потустороннему ужасу — высокая, но необходимая цена " +
//         "за возможность сбежать и попытаться всё исправить. Вы оказываетесь на улице почти перед самым рассветом, дом перед Вами ходит ходуном — " +
//         "то ли от леденящих душу воплей несчастных, то ли от загадочного грохота, то ли от многоголосого демонического смеха. Вас обуревает холодная решимость. " +
//         "Гибель Ваших товарищей не будет напрасной...\n\n" +
//         "В последние минуты перед восходом солнца, Вы одновременно затягиваете древние песнопения, начав ритуал изгнания. " +
//         "Дом начинает сотрясаться всё сильнее, сама земля ходит ходуном под Вашими ногами. Вы, несмотря ни на что, продолжаете вновь и вновь произносить слова из забытых книг, " +
//         "водя хоровод вокруг наспех начерченной вокруг дома защитной печати. Когда же на землю падают первые лучи солнца — окна и двери проклятого дома одновременно распахиваются. " +
//         "Прямо к небесам, разнося жуткие вопли, устремляется клубящееся нечто, один вид которого заставляет Вас кричать от ужаса. " +
//         "Зависнув над скособоченной крышей, чёрное облако навсегда растворяется в лучах солнца, как дым на ветру. Вы с улыбками оседаете на влажную землю. " +
//         "Вы победили! Победили, несмотря ни на что..."),
//     
//     new Ending(2, -10, "Во имя ЕГО мы служим",
//         "Кровавая жертва во спасение невинных принесена... До рассвета осталось совсем немного времени! Вы выскакиваете из дома и спешно начинаете вычерчивать " +
//         "на влажном грунте вокруг дома сдерживающие символы. Они дадут Вам время задержать зло внутри, пока сила ритуала начнёт набирать ход. " +
//         "Вы неуверенно начинаете распевать заковыристый текст ритуала, пока стены дома выгибаются словно живые, а в Ваши уши до боли врезается " +
//         "тысячеликий хохот пока ещё удерживаемого внутри демона. С каждым мгновением Ваши голоса становятся всё увереннее, а в сердцах крепнет вера в свои силы. " +
//         "Вы отправите чудовище обратно в Ад! Но что это? Вы слышите голос. Голос одного из Ваших товарищей! И он читает совсем другой текст... " +
//         "В какой-то момент Вы уже себя не слышите, голос одержимого потусторонней силой становится всё громогласнее. Вы пытаетесь помешать вероломному предательству, " +
//         "но ноги Вас больше не слушаются! В следующее мгновение в голову заливает боль, а из ушей начинает литься кровь. " +
//         "Вы обессиленно падаете на землю. Вы сделали всё, что могли, и даже имели шанс преуспеть, если бы не подлый удар в спину...")
// };
