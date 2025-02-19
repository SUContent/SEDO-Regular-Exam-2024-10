pipeline {
    agent any 

    stages {
        stage("restore") {
            steps {
                powershell 'dotnet restore'
            }
        }

        stage("build") {
            steps {
                powershell 'dotnet build'
            }
        }

        stage("test") {
            steps {
                powershell 'dotnet test'
            }
        }
    }

}