# Это пример использования Flexberry ORM

## Что же такое Flexberry ORM? 
В каждой задаче присутствует задача к доступу к данным в РСУБД. Как правило, она решается применением ORM. Обычно выбираемый ORM — EF.

### Недостатки EF:
1. Неудобно проектировать «от модели» (неудобно разрезать одну модель на несколько диаграмм, нельзя при создании с диаграммы реализовать отображение в СУБД как TPC (Table-per-Concrete Type Inheritance), неудобный редактор моделей); 
2. Невозможно получить DDL-скрипт только для внесённых в модель изменений;
3. EF преследует концепцию: «программист должен иметь всё, за что бы он ни схватился». В результате, запросы идут при дёргании за навигационные свойства, а кроме того, нельзя прочитать сущность таким образом, чтобы были заполнены только некоторые её свойства, в т.ч. свойства тех сущностей, на которые исходная сущность ссылается (EF читает только все свойства, что расходует понапрасну ресурсы, поскольку в большинстве случаев не нужно читать ВСЁ);
4. Если всё-таки читаем часть свойств, то это делается через класс с меньшим количеством полей, либо через анонимный тип, однако эти типы потом не знает контекст, что требует преобразования прочитанных данных к исходным сущностям, если требуется выполнить дальнейшие операции в контексте;
5. Отсутствует возможность внесения в код C#-классов, соответствующих сущностям, изменений, которые бы не утрачивались при повторной перегенерации «поверх» (если это нужно, стандартным выходом является дописывание tt и дописывание в partial-классы);
6. При чтении базовой сущности читаются все унаследованные, которые есть в модели (никак нельзя это ограничить).
7. Отсутствует возможность создания копий связанных сущностей в памяти;
8. Отсутствует поддержка различных СУБД и возможности быстрого написания такой поддержки по собственному желанию, а также поддержки особенностей прикладной задачи на уровне СУБД (например: требуется добавить грязное чтение, либо запись в числовые поля относительных значений).

### Решение:
Есть решение, которое разрешает указанные недостатки и упрощает доступ к данным. 
Давайте его посмотрим.
Продукт называется Flexberry ORM, состоит из 3-х основных частей:

1.	CASE, оснащённый многопользовательским репозитарием моделей, моделирование ведётся в нотации UML;
2.	Framework для поддержки в RunTime разработанных приложений;
3.	Плагины в CASE, в основном, генераторы в СУБД/языки программирования. При этом: генераторы для БД поддерживают выдачу DDL для изменения, код на ЯВУ (C#) может перегенерироваться поверх с сохранением внесённых программистом изменений.

## Концепция Flexberry ORM:
Модель сущностей отрисовывается в диаграммах UML, при этом семантически поддерживаются:
1.	Связи «многие-к-одному»;
2.	Наследование;
3.	Композиция (при этом считается, что композированные объекты являются неотъемлемой частью «шапочного» объекта);

Далее, в соответствии с моделью генерируются:

1.	Таблицы, соотв. сущностям для БД;
2.	Одна или несколько сборок с классами, соотв., сущностям.
В коде всегда применяются одни и те же классы, однозначно выражающие предметные сущности (как для доступа к данным, так и для разработки функционала), что приближает программиста к предметной области. 
Никогда ничего не читается в неявном виде, что даёт контроль над доступом к данным.
Приложение независимо от источника данных (источник и его тип, напр., СУБД изменяются в настройках). 

Рассмотрим использование на примере («библиотека компакт-дисков»):
 
Для этой диаграммы Flexberry ORM сгенерировала БД по правилам TPC, а также код для сущностей на языке C#.

### Давайте рассмотрим примеры кода для различных задач:

#### 1. Создание и сохранение сущностей в БД

```csharp
            Страна стр1 = new Страна();
            стр1.Название = "Россия";
            Страна стр2 = new Страна();
            стр2.Название = "США";
            Страна стр3 = new Страна();
            стр3.Название = "Ирландия";
 
            Человек чел1 = new Человек();
            чел1.Фамилия = "Иванов";
            чел1.Имя = "Иван";
            Человек чел2 = new Человек();
            чел2.Фамилия = "Сидоров";
            чел2.Имя = "Сидор";
 
            Издатель изд = new Издатель();
            изд.Название = "Первый издатель";
            изд.Страна = стр1;
 
            Издатель изд1 = new Издатель();
            изд1.Название = "Второй издатель";
            изд1.Страна = стр2;
 
            CDDA cdda = new CDDA();
            cdda.Издатель = изд;
            cdda.Название = "Музыка советского кино";
            cdda.Композиция.Add(new Композиция(){Название="Мой друг - зонтик", Автор=чел1, Исполнитель=чел2});
            cdda.Композиция.Add(new Композиция(){ Название = "Здравствуйте, я ваша тетя!", Автор = чел2, Исполнитель = чел1 });
 
            CDDD cddd = new CDDD();
            cddd.Издатель = изд1;
            cddd.Название = "Windows XP";
            cddd.Объём = 640;
 
            System.Collections.Generic.List<ICSSoft.STORMNET.DataObject> objstoupdlist = new List<ICSSoft.STORMNET.DataObject>();
 
            for (int i = 0; i < 5; i++)
            {
                DVD dvd = new DVD();
                dvd.Издатель = изд;
                dvd.Название = string.Format("Симпсоны {0}", i);
                dvd.Объём = i*100;
                objstoupdlist.Add(dvd);
            }
 
            objstoupdlist.AddRange(new ICSSoft.STORMNET.DataObject[] { стр1, стр2, стр3, чел1, чел2, изд, изд1, cdda, cddd });
                             
            try
            {
                ICSSoft.STORMNET.DataObject[] objstoupd = objstoupdlist.ToArray();
                DataServiceProvider.DataService.UpdateObjects(ref objstoupd);
                MessageBox.Show("OK!");
            }
            catch (Exception exc)
            {
                MessageBox.Show(string.Format("БАГА: {0}", exc.ToString()));
            }
 ```
 
В этом примере важно:

* Сущности соответствуют диаграммным один-в-один;
* Все объекты, переданные в DataService.UpdateObjects сохраняются в одной транзакции;
* Несмотря на то, что сохраняются разнотипные объекты, причем в общем случае, имеют разные состояния (некоторые создаются, некоторые удаляются, некоторые обновляются), порядок их следования в массиве не имеет значения (зависимости между объектами и, соответственно, порядок исполнения запросов определяются сервисом данных автоматически);
* Нет никакого контекста, как в EF, сущности – просто инстанции соотв. классов.
* Композированные объекты будут сохранены вместе с шапками (сервису данных можно не указывать композированные объекты, они являются неотъемлемыми частями шапок).

#### 2. Манипуляция единичными сущностями

```csharp
            CDDA cdda = new CDDA();
            cdda.SetExistObjectPrimaryKey("12CF919A-A309-43F1-A240-9723E3B0B125");            
            
            DataServiceProvider.DataService.LoadObject("CDDA_E", cdda);
            cdda.Название = "Блаблабла";
            DataServiceProvider.DataService.UpdateObject(cdda);
```
В этом примере важно:

* Концепция представлений (представление описывает множество атрибутов (как собственных, так и связанных классов), в котором выполняется чтение сущностей, только указанные в представлении свойства будут означены). Существуют развитые механизмы конструирования представлений, в т.ч. и создание представлений «по-умолчанию» со «всеми атрибутами»;
* Для выражения сущности аудио-CD есть один единственный класс CDDA, он используется ВЕЗДЕ, в данном случае, прямо его объект создаётся из БД, изменяется свойство и он же передаётся на сохранение, нет никаких дополнительных классов для выражения предметной сущности;
* Сервис данных автоматически определяет, что следует сделать с записью в БД для этого объекта исходя из 2-х встроенных статусов объекта: Статуса загрузки (не вычитан, вычитан и какие свойства) и статуса состояния (создан, изменён, удалён, …);
* Попытка обновить свойство, которое у сущности не вычитано, — невозможна, будет Exception.

#### 3. Чтение списков сущностей

```csharp
            ICSSoft.STORMNET.FunctionalLanguage.SQLWhere.SQLWhereLanguageDef ld = ICSSoft.STORMNET.FunctionalLanguage.SQLWhere.SQLWhereLanguageDef.LanguageDef;
 
            LoadingCustomizationStruct lcs = new LoadingCustomizationStruct(null);
            lcs.View = Information.GetView("CD_E", typeof(CD)); //Представление, в котором будут прочитанные объекты
            lcs.LoadingTypes = new Type[] { typeof(CDDA), typeof(CDDD), typeof(DVD) }; //Читаются только указанные наследники класса CD
            lcs.LimitFunction = ld.GetFunction(ld.funcEQ, new VariableDef(ld.StringType, "Издатель.Страна.Название"), "США"); //Ограничение на издателя, только США
            lcs.ColumnsSort = new ColumnsSortDef[] { new ColumnsSortDef("Название", ICSSoft.STORMNET.Business.SortOrder.Asc) }; //Выполнить сортировку по названию диска
            //lcs.RowNumber =new RowNumberDef(2, 5); //Постраничное чтение
 
            ICSSoft.STORMNET.DataObject[] objs = DataServiceProvider.DataService.LoadObjects(lcs);
```

В этом примере важно:

* Указывается представление, в котором будут результирующие объекты;
* Указываются типы, которые должны быть вычитаны, ведь в общем случае возможно наследование от класса, который используется в представлении;
* Указываются ограничения на свойства сущностей, выражение может быть сколь угодно сложным (по сути, WHERE). Также, в последних версиях здесь поддерживается LINQ;
* Указывается, каким образом нужно произвести упорядочение (по сути, ORDER BY).

#### 4. Сервис данных для иных хранилищ, либо поддержка особенностей прикладной задачи на уровне хранилища. Например: требуется сервис данных, выполняющий грязное чтение в MSSQL.

```csharp
    public class DirtyReadMSSQLDataService : MSSQLDataService
    {
        public override string GetJoinTableModifierExpression()
        {
            return " WITH (NOLOCK)";
        }
    }
```

В этом примере важно:

* От любого из стандартных сервисов данных, как и от базового SQLDataService (кстати, запросы к хранилищу в нём соответствуют стандарту SQL ANSI, что позволяет легко поддерживать произвольные реляционные хранилища) делается наследник;
* Есть большое количество методов, которые можно перегрузить в наследнике, чтобы поддержать требуемую специфику. В данном примере, в каждый JOIN добавляется модификатор грязного чтения.

Итак, мы рассмотрели на примере основные возможности Flexberry ORM, перечислю также некоторые частности:

1.	Готовые сервисы данных для MSSQL, ORACLE, POSTGRE, MYSQL, ACCESS. Причём для приложения просто изменяются настройки, никаких изменений в исходный код не вносится;
2.	Поддержка первичных ключей различных типов, возможность изменить стандартные генераторы первичных ключей;
3.	Названия таблиц, полей в БД могут меняться, нет никакой строгой привязки, таким образом, можно использовать CASEBERRY для поддержки (интеграции в) старых систем на уровне БД.
