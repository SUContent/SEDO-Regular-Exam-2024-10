pipeline {
    agent any 
    stages {
        stage('Restore Dependecies') { 
            steps {
              bat 'dotenet restore' // 
            }
        }
        stage('Dotnet Build') { 
            steps {
               bat 'dotnet build --no-restore' // 
            }
        }
        stage('Execute tests') { 
            steps {
              bat 'dotnet test --no-build --verbosity normal'  // 
            }
        }
    }
}
