pipeline {
    agent any 
  stages {
    
    stage('Restore Dependencies') {
     steps {
          bat 'dotnet restore'
            }
        }
    stage('Dotnet Build') { 
     steps {
         'dotnet build --no-restore' 
            }
        }
    stage('Ececute Tests') { 
        steps {
         'dotnet test --no-build --verbosity normal'
            }
        }
    }
}
