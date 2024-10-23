pipeline {
    agent any
        stages{
            stage('Restore Dependencier') {
                steps {
                        bat 'dotnet restore'
                    }
                }
          
            stage('Build Application') {
                steps {
                        bat 'dotnet build --no-restore'
                    }
                }
          
            stage('Execute Tests') {
                steps {
                        bat 'dotnet test --no-build --verbosity normal'
                    }
             }
        }
    }
