# Публикация на IIS
После публикации на IIS могут возникнуть ошибки при подключении к .mdf файлу базы данных. Для решения нужно найти файл `C:\Windows\System32\inetsrv\config`, найти в нем `processModel` тег и изменить его содержимое:
```xml
<processModel identityType="ApplicationPoolIdentity" loadUserProfile="true" setProfileEnvironment="true" />
```

После этого перезапустить IIS. Этого должно хватить.