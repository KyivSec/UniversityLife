# UniversityLife

# Для контрибьюторів

## Додавання проєкту

Щоб додати цей проєкт на свій комп'ютер, слідуйте чітко за цією інструкцією:

1. Клонуйте або запульте репозиторій до бажаної папки, де ви будете тримати проєкт:

```git
# Для клонування (для тих хто знає git):
git clone git@github.com:KyivSec/UniversityLife.git


# Для пулу (рекомендовано):
git init
git remote add origin git@github.com:KyivSec/UniversityLife.git
git pull origin main
```

2. Завантажте [UnityHub](https://unity.com/download), зареєструйтесь або залогінтесь.

3. Завантажте версію рушія **6000.2.2f1**.

4. Натисніть кнопку *Add* праворуч зверху, та оберіть *Add project from disk*:

5. ![Зображення Add project from disk](https://cdn.discordapp.com/attachments/1414609032680968194/1414979961537822720/image.png?ex=68c18a47&is=68c038c7&hm=9ed21b61476b2ddaaf19dc4d4d00e18d64306ad6813070208c7ab71fc8ca026e&)

6. У списку проєктів повинен з'явитися проєкт **University Life**. Натисніть на нього та дочекайтесь ініціалізації бібліотек.

7. Починайте працювати.

## Збірка гри

Якщо ви збираєтесь білдити гру, вам необхідно дотриматись таких умов:

1. Завантажте *Build Support* під вашу систему шляхом **Installs -> Unity 6.2 -> Add Modules -> "**Windows Build Support (Mono)"**.*
   **ОБОВ'ЯЗКОВО MONO, IL2CPP НЕ ПІДІЙДЕ!!!**
   ![Зображення Add modules](https://cdn.discordapp.com/attachments/1415008906991898705/1415033030552191006/image.png?ex=68c1bbb4&is=68c06a34&hm=35c0e871cff927af1a9eb3ec0e11a3d00aa96aa3e3935b44bd7cce44982fd987&)
   **Переконайтеся, що ви зняли ластівку з модулю "Microsoft Visual Studio Community 2022" зверху!**
   Також може знадобитись перезапустити Unity.

2. Перевірте білд-профіль шляхом *File -> Build Profiles*. Він повинен бути ідентичним до зображення (призначений для дебаггінгу та загального тестування):
   ![Зображення Build Profiles](https://cdn.discordapp.com/attachments/1415008906991898705/1415036797234315344/image.png?ex=68c1bf36&is=68c06db6&hm=0d2d485e4f8e0527ff729985afe2cd10eb294d706c4e802d1bbcf299aaaf76b6&)

3. Якщо ви додали нові сцени, їх треба також додати до списку сцен у *Build Profiles -> Scene List*, наприклад відкривши необхідну сцену та натиснувши *Add Open Scenes*.
   Зверніть увагу - у скрипті до сцен можна звертатися як за ім'ям, так і за ID. **Змінювати порядок сцен категорично не рекомендується!**

4. Нарешті натисніть кнопку *Build* та оберіть папку куди зібрати гру.
