pipeline {
    agent any 
    stages {
        stage('Restore dependencies') { 
            steps {
                echo 'dotnet restore' 
            }
        }
        stage('Dotnet Build') { 
            steps {
                echo 'dotnet build --no-restore' 
            }
        }
        stage('Execute tests') { 
            steps {
                echo 'dotnet test --no-build --verbosity normal' 
            }
        }
    }
}
