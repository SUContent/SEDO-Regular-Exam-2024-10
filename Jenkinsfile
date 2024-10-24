pipeline {
  agent any
  stages {
    stage('Restore dependencies') {
      steps {
        bar 'dotnet restore'
      }
    }
    stage('Dotnet Build') {
      steps {
        bar 'dotnet build --no-restore'
      }
    }
    stage('Execute tests') {
      steps {
        bar 'dotnet test --no-build --verbosity normal'
      }
    }
  }
}
