pipeline {
    agent {
        docker {
            image 'mcr.microsoft.com/dotnet/sdk:6.0'
            args '-v /var/run/docker.sock:/var/run/docker.sock' // Optional: if you need docker within docker
        }
    }
  
    stages {
        stage('Build and Run Tests') {
            steps {
                script {
                    sh 'dotnet restore'
                    sh 'dotnet build --no-restore'
                    sh 'dotnet test --no-build --verbosity normal'
                }
            }
        }
    }
}
