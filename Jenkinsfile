pipeline {
  agent any

  stages {

    stage('Restore Dependencies') {
      steps {
        sh 'dotnet restore'
      }
    }

    stage('Build The Application') {
      steps {
        sh 'dotnet build --no-restore'
      }
    }

    stage('Run Application Tests') {
      steps {
        sh 'dotnet test --no-build --verbosity normal'
      }
    }

  }
}