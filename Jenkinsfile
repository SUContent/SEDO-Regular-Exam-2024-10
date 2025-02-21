pipeline {
  agent any
  stages {
    stage('Build Project') {
      steps {
        bat 'dotnet build'
      }
    }
    stage('Run dotnet test') {
      steps {
        bat 'dotnet test'
      }
    }
  }
}